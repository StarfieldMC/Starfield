namespace nylium.Core.Entity.Entities {

    public class PlayerEntity : GameEntity {

        public PlayerEntity(World.GameWorld parent, double x, double y, double z, int yaw, int pitch) : base(parent, "minecraft:player", x, y, z, yaw, pitch) { }
    }
}
