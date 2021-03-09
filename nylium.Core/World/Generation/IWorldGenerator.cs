using System;

namespace nylium.Core.World.Generation {

    public interface IWorldGenerator {

        public void GenerateChunk(World world, Chunk chunk);
    }
}
