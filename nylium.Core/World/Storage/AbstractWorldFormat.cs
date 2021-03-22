using System;

namespace nylium.Core.World.Storage {

    public abstract class AbstractWorldFormat : IDisposable {

        public GameWorld World { get; }

        public AbstractWorldFormat(GameWorld world) {
            World = world;
        }

        public abstract void Load();
        public abstract void Save();

        public abstract Chunk Load(int chunkX, int chunkZ);
        public abstract void Save(Chunk chunk);
        public abstract void Dispose();
    }
}