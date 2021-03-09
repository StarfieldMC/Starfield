namespace nylium.Core.Entity {

    public class Entity {

        public World.World Parent { get; }

        public string Id { get; }
        public int EntityId { get; }

        public double X { get; }
        public double Y { get; }
        public double Z { get; }

        public int Yaw { get; }
        public int Pitch { get; }

        public Entity(World.World parent, string id, double x, double y, double z, int yaw, int pitch) {
            Parent = parent;
            Id = id;
            EntityId = parent.GetNextEntityId(this);

            X = x;
            Y = y;
            Z = z;

            Yaw = yaw;
            Pitch = pitch;
        }
    }
}
