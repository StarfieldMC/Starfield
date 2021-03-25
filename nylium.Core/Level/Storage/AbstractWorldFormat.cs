using System;

namespace nylium.Core.Level.Storage {

    public abstract class AbstractWorldFormat : IDisposable {

        public World World { get; }

        public AbstractWorldFormat(World world) {
            World = world;
        }

        public abstract void Load();
        public abstract void Save();

        public abstract Chunk Load(int chunkX, int chunkZ);
        public abstract void Save(Chunk chunk);
        public abstract void Dispose();
    }
}