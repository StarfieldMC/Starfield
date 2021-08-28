namespace Starfield.Core.Level.Generation {

    public interface IWorldGenerator {

        public void GenerateChunk(World world, Chunk chunk);
        public string GetName();
    }
}
