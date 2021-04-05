namespace nylium.Core.Level.Generation {

    public abstract class AbstractWorldGenerator {

        public World World { get; set; }
        public dynamic Arguments { get; set; }

        public virtual void Initialize(World world, object args) {
            World = world;
            Arguments = args;
        }

        public abstract void GenerateChunk(Chunk chunk);
        public abstract string GetName();
    }
}
