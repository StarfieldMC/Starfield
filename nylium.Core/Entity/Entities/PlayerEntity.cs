using System;
using DaanV2.UUID;
using nylium.Core.World;
using nylium.Utilities;

namespace nylium.Core.Entity.Entities {

    public class PlayerEntity : GameEntity {

        public string Username { get; }
        public UUID Uuid { get; }

        public Gamemode Gamemode { get; }

        public PlayerEntity(GameWorld parent, string username, UUID uuid, Gamemode gamemode, double x, double y, double z, float yaw, float pitch, bool onGround) : base(parent, "minecraft:player", x, y, z, yaw, pitch, onGround) {
            Username = username;
            Uuid = uuid;
            Gamemode = gamemode;
        }
    }
}