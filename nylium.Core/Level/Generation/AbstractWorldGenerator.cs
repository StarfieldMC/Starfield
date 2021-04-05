namespace nylium.Core.Level.Generation {

    public abstract class AbstractWorldGenerator {

        public World World { get; }
        public dynamic Arguments { get; }

        public AbstractWorldGenerator(World world, object args) {
            World = world;
            Arguments = args;
        }

        public abstract void GenerateChunk(Chunk chunk);
        public abstract string GetName();
    }
}
