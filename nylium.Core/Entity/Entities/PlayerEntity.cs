using System;
using System.Collections.Generic;
using System.Linq;
using DaanV2.UUID;
using nylium.Core.Packet;
using nylium.Core.Packet.Client.Play;
using nylium.Core.Packet.Server.Play;
using nylium.Core.World;
using nylium.Utilities;

namespace nylium.Core.Entity.Entities {

    public class PlayerEntity : GameEntity {

        public GameClient Client { get; }

        public string Username { get; }
        public UUID Uuid { get; }

        public Gamemode Gamemode { get; }

        public PlayerEntity(GameWorld parent, GameClient client, string username, UUID uuid, Gamemode gamemode,
            double x, double y, double z, float yaw, float pitch, bool onGround) : base(parent, "minecraft:player", x, y, z, yaw, pitch, onGround) {

            Client = client;
            Username = username;
            Uuid = uuid;
            Gamemode = gamemode;
        }

        public void HandleMovement(NetworkPacket packet) {
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
                case CP12PlayerPosition:
                    CP12PlayerPosition p = (CP12PlayerPosition) packet;
                    newX = p.X;
                    newY = p.FeetY;
                    newZ = p.Z;
                    newOnGround = p.OnGround;
                    break;
                case CP13PlayerPositionAndRotation:
                    CP13PlayerPositionAndRotation _p = (CP13PlayerPositionAndRotation) packet;
                    newX = _p.X;
                    newY = _p.FeetY;
                    newZ = _p.Z;
                    newYaw = _p.Yaw;
                    newPitch = _p.Pitch;
                    newOnGround = _p.OnGround;
                    break;
                case CP14PlayerRotation:
                    CP14PlayerRotation __p = (CP14PlayerRotation) packet;
                    newYaw = __p.Yaw;
                    newPitch = __p.Pitch;
                    newOnGround = __p.OnGround;
                    break;
                case CP15PlayerMovement:
                    SP2AEntityMovement entityMovement = new(EntityId);
                    Client.Server.MulticastAsync(entityMovement, Client);
                    return;
            }

            if(newX != LastX || newY != LastY || newZ != LastZ) {
                if(double.IsInfinity(newX) || double.IsInfinity(newY) || double.IsInfinity(newZ)
                    || newX > 3.2 * Math.Pow(10, 7) || newZ > 3.2 * Math.Pow(10, 7)) {

                    SP19Disconnect disconnect = new(new {
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
                    Console.WriteLine($"Client with id [{Id}] moved too fast!");

                    SP56EntityTeleport teleport = new(EntityId, LastX, LastY, LastZ,
                        Yaw, Pitch, LastOnGround);
                    Client.Send(teleport);
                }

                X = newX;
                Y = newY;
                Z = newZ;
                OnGround = newOnGround;

                SP27EntityPosition entityPosition = new(EntityId,
                    (short) (((X * 32) - (LastX * 32)) * 128),
                    (short) (((Y * 32) - (LastY * 32)) * 128),
                    (short) (((Z * 32) - (LastZ * 32)) * 128),
                    OnGround);
                Client.Server.MulticastAsync(entityPosition, Client);

                // player changed chunk
                if(Math.Floor(X / 16) != Math.Floor(LastX / 16)
                    || Math.Floor(Z / 16) != Math.Floor(LastZ / 16)) {

                    Chunk[] chunks = Parent.GetChunksInViewDistance((int) Math.Floor(X / 16), (int) Math.Floor(Z / 16), Client.Configuration.ViewDistance);

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

                SP29EntityRotation entityRotation = new(EntityId, Yaw, Pitch, OnGround);
                Client.Server.MulticastAsync(entityRotation, Client);
            }
        }
    }
}