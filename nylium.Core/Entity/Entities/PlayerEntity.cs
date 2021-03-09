namespace nylium.Core.Entity.Entities {

    public class PlayerEntity : Entity {

        public PlayerEntity(World.World parent, double x, double y, double z, int yaw, int pitch) : base(parent, "minecraft:player", x, y, z, yaw, pitch) { }
    }
}
