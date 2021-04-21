using System;
using System.Threading.Tasks;
using nylium.Core.Entity.Entities;

namespace nylium.Core.Level.Storage {

    public abstract class AbstractWorldFormat : IDisposable {

        public World World { get; }

        public AbstractWorldFormat(World world) {
            World = world;
        }

        public virtual async Task<bool> Load() { return true; }
        public virtual async Task<bool> Save() { return true; }

        public virtual async Task<bool> Load(Chunk chunk) { return true; }
        public virtual async Task<bool> Save(Chunk chunk) { return true; }

        public virtual async Task<bool> Load(PlayerEntity player) { return true; }
        public virtual async Task<bool> Save(PlayerEntity player) { return true; }

        public abstract void Dispose();
    }
}