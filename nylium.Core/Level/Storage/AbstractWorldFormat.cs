using System;
using nylium.Core.Entity.Entities;

namespace nylium.Core.Level.Storage {

    public abstract class AbstractWorldFormat : IDisposable {

        public World World { get; }

        public AbstractWorldFormat(World world) {
            World = world;
        }

        public abstract bool Load();
        public abstract bool Save();

        public abstract bool Load(Chunk chunk);
        public abstract bool Save(Chunk chunk);

        public abstract bool Load(PlayerEntity player);
        public abstract bool Save(PlayerEntity player);

        public abstract void Dispose();
    }
}