﻿using System;
using System.Collections.Generic;
using System.Linq;
using DaanV2.UUID;
using Starfield.Logging;
using Starfield.Utilities;
using Starfield.Core.Block;
using Starfield.Core.Block.Blocks;
using Starfield.Core.Entity.Inventories;
using Starfield.Core.Item;
using Starfield.Core.Level;
using Starfield.Core.Networking;
using Starfield.Core.Networking.Packet;
using Starfield.Core.Networking.Packet.Client.Play;
using Starfield.Core.Networking.Packet.Server.Play;

namespace Starfield.Core.Entity.Entities {

    public class PlayerEntity : BaseEntity {

        public MinecraftClient Client { get; }

        public string Username { get; }
        public UUID Uuid { get; }

        public Gamemode Gamemode { get; set; }

        public int ChunkX {
            get {
                return (int) Math.Floor(X / Chunk.X_SIZE);
            }
        }

        public int ChunkZ {
            get {
                return (int) Math.Floor(Z / Chunk.Z_SIZE);
            }
        }

        public PlayerEntity(World parent, MinecraftClient client, string username, UUID uuid, Gamemode gamemode,
            double x, double y, double z, float yaw, float pitch, bool onGround) : base(parent, "minecraft:player", x, y, z, yaw, pitch, onGround, 45) {

            Client = client;
            Username = username;
            Uuid = uuid;
            Gamemode = gamemode;
            Inventory.HeldSlot = 36;

            Parent.Format.Load(this);
        }

        public void HandleMovement(MinecraftPacket packet) {
            LastX = X;
            LastY = Y;
            LastZ = Z;
            LastOnGround = OnGround;

            double newX = X;
            double newY = Y;
            double newZ = Z;
            float newYaw = Yaw;
            float newPitch = Pitch;
            bool newOnGround = OnGround;

            switch(packet) {
                case CP12PlayerPosition p:
                    newX = p.X;
                    newY = p.FeetY;
                    newZ = p.Z;
                    newOnGround = p.OnGround;
                    break;
                case CP13PlayerPositionAndRotation _p:
                    newX = _p.X;
                    newY = _p.FeetY;
                    newZ = _p.Z;
                    newYaw = _p.Yaw;
                    newPitch = _p.Pitch;
                    newOnGround = _p.OnGround;
                    break;
                case CP14PlayerRotation __p:
                    newYaw = __p.Yaw;
                    newPitch = __p.Pitch;
                    newOnGround = __p.OnGround;
                    break;
                case CP15PlayerMovement:
                    SP2AEntityMovement entityMovement = new(Client, EntityId);
                    Client.Server.MulticastAsync(entityMovement, Client);
                    return;
            }

            if(newX != LastX || newY != LastY || newZ != LastZ) {
                if(double.IsInfinity(newX) || double.IsInfinity(newY) || double.IsInfinity(newZ)
                    || newX > 3.2 * Math.Pow(10, 7) || newZ > 3.2 * Math.Pow(10, 7)) {

                    SP19Disconnect disconnect = new(Client, new {
                        text = "Invalid move packet received"
                    });
                    Client.Send(disconnect);
                    Client.Disconnect();
                }

                double deltaX = newX - LastX;
                double deltaY = newY - LastY;
                double deltaZ = newZ - LastZ;

                double total = Math.Pow(deltaX, 2) + Math.Pow(deltaY, 2) + Math.Pow(deltaZ, 2);
                double expected = Math.Pow(LastX, 2) + Math.Pow(LastY, 2) + Math.Pow(LastZ, 2);

                // TODO               300 if elytra
                if(total - expected > 100) {
                    Logger.Info($"Player [{Username}] moved too fast!");

                    SP56EntityTeleport teleport = new(Client, EntityId, LastX, LastY, LastZ,
                        Yaw, Pitch, LastOnGround);
                    Client.Send(teleport);
                }

                X = newX;
                Y = newY;
                Z = newZ;
                OnGround = newOnGround;

                SP27EntityPosition entityPosition = new(Client, EntityId,
                    (short) (((X * 32) - (LastX * 32)) * 128),
                    (short) (((Y * 32) - (LastY * 32)) * 128),
                    (short) (((Z * 32) - (LastZ * 32)) * 128),
                    OnGround);
                Client.Server.MulticastAsync(entityPosition, Client);

                // player changed chunk
                if(ChunkX != (int) Math.Floor(LastX / Chunk.X_SIZE)
                    || ChunkZ != (int) Math.Floor(LastZ / Chunk.Z_SIZE)) {

                    SP40UpdateViewPosition updateViewPosition = new(Client, ChunkX, ChunkZ);
                    Client.Send(updateViewPosition);

                    Chunk[] chunks = Parent.GetChunksInViewDistance(ChunkX, ChunkZ, Client.Configuration.ViewDistance);

                    IEnumerable<Chunk> toUnload = Client.LoadedChunks.Except(chunks);
                    IEnumerable<Chunk> toLoad = chunks.Except(Client.LoadedChunks);

                    Client.UnloadChunks(toUnload.ToArray());
                    Client.LoadChunks(toLoad.ToArray());
                }
            }

            // TODO fix this somehow
            if(newYaw != Yaw || newPitch != Pitch) {
                double x = -Math.Cos(newPitch) * Math.Sin(newYaw);
                double y = -Math.Sin(newPitch);
                double z = Math.Cos(newPitch) * Math.Cos(newYaw);

                double dx = x - X;
                double dy = y - Y;
                double dz = z - Z;

                double r = Math.Sqrt((dx * dx) + (dy * dy) + (dz * dz));
                double yaw = (-Math.Atan2(dx, dz) / Math.PI) * 180;

                if(yaw < 0) yaw = 360 + yaw;

                double pitch = (-Math.Asin(dy / r) / Math.PI) * 180;

                Yaw = (float) yaw;
                Pitch = (float) pitch;

                OnGround = newOnGround;

                SP29EntityRotation entityRotation = new(Client, EntityId, Yaw, Pitch, OnGround);
                Client.Server.MulticastAsync(entityRotation, Client);
            }
        }

        public void HandleWorldAction(MinecraftPacket packet) {
            switch(packet) {
                case CP1BPlayerDigging digging:
                    bool IsLegal(double x1, double y1, double z1, double x2, double y2, double z2) {
                        return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2)) <= 6.0;
                    }
                    
                    BlockBase block = Parent.GetBlock(digging.Location.X, digging.Location.Y, digging.Location.Z);
                    SP07AcknowledgePlayerDigging acknowledgePlayerDigging;

                    if(block == null) {
                        acknowledgePlayerDigging = new SP07AcknowledgePlayerDigging(Client, digging.Location, 0,
                            (SP07AcknowledgePlayerDigging.ActionType) digging.Status, false);
                        Client.Send(acknowledgePlayerDigging);
                        break;
                    }

                    if(!IsLegal(X, Y + 1.5, Z, digging.Location.X, digging.Location.Y, digging.Location.Z)) {
                        acknowledgePlayerDigging = new SP07AcknowledgePlayerDigging(Client, digging.Location, block.State,
                            (SP07AcknowledgePlayerDigging.ActionType) digging.Status, false);
                        Client.Send(acknowledgePlayerDigging);
                        break;
                    }

                    acknowledgePlayerDigging = new SP07AcknowledgePlayerDigging(Client, digging.Location, block.State,
                        (SP07AcknowledgePlayerDigging.ActionType) digging.Status, true);
                    Client.Send(acknowledgePlayerDigging);

                    // TODO block break animation

                    CP1BPlayerDigging.ActionType requiredAction;

                    if(Gamemode == Gamemode.Creative) {
                        requiredAction = CP1BPlayerDigging.ActionType.StartedDigging;
                    } else {
                        requiredAction = CP1BPlayerDigging.ActionType.FinishedDigging;
                    }

                    if(digging.Status == requiredAction) {
                        BlockBase air = new BlockAir();

                        Parent.SetBlock(air, digging.Location.X, digging.Location.Y, digging.Location.Z);

                        SP0BBlockChange blockChange = new(null, digging.Location, air.State);
                        Client.Server.MulticastAsync(blockChange, Client, Parent.GetClientsWithChunkLoaded(
                            (int) Math.Floor((double) digging.Location.X / Chunk.X_SIZE),
                            (int) Math.Floor((double) digging.Location.Z / Chunk.Z_SIZE)).ToArray());
                    }
                    break;
                case CP2EPlayerBlockPlacement playerBlockPlacement:
                    Position.Int pos = new(playerBlockPlacement.Location);

                    switch(playerBlockPlacement.Face) {
                        case Face.Top:
                            pos.Y++;
                            break;
                        case Face.Bottom:
                            pos.Y--;
                            break;
                        case Face.North:
                            pos.Z--;
                            break;
                        case Face.East:
                            pos.X++;
                            break;
                        case Face.South:
                            pos.Z++;
                            break;
                        case Face.West:
                            pos.X--;
                            break;
                    }

                    // TODO check for collisions here

                    if(Parent.GetBlock(pos.X, pos.Y, pos.Z) == null) {
                        Inventory.Slot held = Inventory.Slots[Inventory.HeldSlot];
                        
                        if(!held.IsEmpty() && held.Item is BlockItem item) {
                            block = BlockRepository.Create(item.BlockProtocolId);
                            
                            if(block == null || block.State == 0) {
                                break;
                            }

                            if(pos.Y < 0 || pos.Y >= Chunk.Y_SIZE) return;

                            Parent.SetBlock(block, pos.X, pos.Y, pos.Z);

                            SP0BBlockChange _blockChange = new(null, pos, block.State);
                            Client.Server.MulticastAsync(_blockChange, Client, Parent.GetClientsWithChunkLoaded(
                                (int) Math.Floor((double) pos.X / Chunk.X_SIZE),
                                (int) Math.Floor((double) pos.Z / Chunk.Z_SIZE)).ToArray());
                        }
                    }
                    break;
                case CP1CEntityAction:
                    break;
            }
        }

        public void HandleInventoryAction(MinecraftPacket packet) {
            switch(packet) {
                case CP25HeldItemChange heldItemChange:
                    Inventory.HeldSlot = heldItemChange.Slot + 36; // mojang moment
                    break;
                case CP28CreativeInventoryAction creativeInventoryAction:
                    if(creativeInventoryAction.Slot == -1) {
                        // TODO spawn item entity here
                    } else {
                        Inventory.Slots[creativeInventoryAction.Slot]
                            = creativeInventoryAction.ClickedItem.IsEmpty() ?
                              Inventories.Inventory.Slot.Empty : creativeInventoryAction.ClickedItem;
                    }
                    break;
            }
        }
    }
}