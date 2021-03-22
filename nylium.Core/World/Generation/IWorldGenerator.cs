using System;

namespace nylium.Core.World.Generation {

    public interface IWorldGenerator {

        public void GenerateChunk(GameWorld world, Chunk chunk);
        public string GetName();
    }
}
