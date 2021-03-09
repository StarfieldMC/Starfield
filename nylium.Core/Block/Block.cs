using System.Collections.Generic;

namespace nylium.Core.Block {

    public class Block {
        
        //                                  id   x    y    z
        private static readonly Dictionary<(int, int, int, int), Block> blockCache = new();

        public World.World Parent { get; }
        public int Id { get; set; }

        public int X { get; }
        public int Y { get; }
        public int Z { get; }

        private Block(World.World parent, int id, int x, int y, int z) {
            Parent = parent;
            Id = id;

            X = x;
            Y = y;
            Z = z;
        }

        public static Block Create(World.World parent, int id, int x, int y, int z) {
            (int, int, int, int) t = (id, x, y, z);

            if(blockCache.ContainsKey(t)) {
                return blockCache[t];
            }

            Block block = new(parent, id, x, y, z);
            blockCache.Add(t, block);

            return block;
        }
    }
}
