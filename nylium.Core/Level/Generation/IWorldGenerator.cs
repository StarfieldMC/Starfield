namespace nylium.Core.Level.Generation {

    public interface IWorldGenerator {

        public void GenerateChunk(GameWorld world, Chunk chunk);
        public string GetName();
    }
}
