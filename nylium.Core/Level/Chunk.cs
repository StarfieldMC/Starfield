using System;
using System.Collections;
using nylium.Core.Blocks;
using nylium.Extensions;
using nylium.Nbt.Tags;

namespace nylium.Core.Level {

    public class Chunk {

        public const int X_SIZE = 16;
        public const int Z_SIZE = 16;
        public const int Y_SIZE = 256;
        public const int SECTION_COUNT = Y_SIZE / Section.Y_SIZE;

        public World Parent { get; }

        public int X { get; }
        public int Z { get; }

        //       present  y     stateid
        private (bool,    byte, ushort)[,] Heightmap { get; }
        public Section[] Sections { get; }

        public Chunk(World parent, int x, int z) {
            Parent = parent;

            X = x;
            Z = z;

            Heightmap = new (bool, byte, ushort)[X_SIZE, Z_SIZE];
            Sections = new Section[SECTION_COUNT];
        }

        public Block GetBlock(int x, int y, int z) {
            if(y < 0 || y >= Y_SIZE) return null;

            int id = (int) Math.Floor((double) y / Section.Y_SIZE);
            if(Sections[id] == null) return null;

            y -= (id * Section.Y_SIZE);
            return Sections[id].GetBlock(x, y, z);
        }

        public void SetBlock(Block block, int x, int y, int z) {
            if(y < 0 || y >= Y_SIZE) return;

            int id = (int) Math.Floor((double) y / Section.Y_SIZE);
            if(Sections[id] == null) Sections[id] = new(id, this);

            y -= (id * Section.Y_SIZE);
            Sections[id].SetBlock(block, x, y, z);
        }

        public TagCompound CreateHeightmap() {
            long[] data = new long[37];

            // TODO fuck this shit
            //int dataIndex = data.Length - 1;

            //byte entryIndex = (sizeof(long) * 8) - 2;
            //byte entryLength = 9;

            //for(int z = 0; z < Z_SIZE; z++) {
            //    for(int x = 0; x < X_SIZE; x++) {
            //        if(entryIndex <= 0) {
            //            dataIndex--;
            //            entryIndex = (sizeof(long) * 8) - 2;
            //        }

            //        (bool, byte, ushort) block = Heightmap[x, z];
            //        data[dataIndex].ClearBit(entryIndex);
            //        entryIndex--;

            //        for(int i = 0; i < entryLength - 1; i++) {
            //            if(block.Item2.IsBitSet((byte) i)) {
            //                data[dataIndex].SetBit(entryIndex);
            //            } else {
            //                data[dataIndex].ClearBit(entryIndex);
            //            }

            //            entryIndex--;
            //        }
            //    }
            //}

            return new("") {
                new TagLongArray("MOTION_BLOCKING", data)
            };
        }

        public class Section {

            public const int X_SIZE = 16;
            public const int Z_SIZE = 16;
            public const int Y_SIZE = 16;

            public int Id { get; }
            public Chunk Parent { get; }
            private Block[,,] Blocks { get; }

            public Section(int id, Chunk parent) {
                Id = id;
                Parent = parent;
                Blocks = new Block[Y_SIZE, X_SIZE, Z_SIZE];
            }

            public Section(int id, Chunk parent, Block[,,] blocks) {
                Id = id;
                Parent = parent;
                Blocks = blocks;
            }

            public Block GetBlock(int x, int y, int z) {
                if(x < 0 || y < 0 || z < 0) return null;
                if(x >= X_SIZE || y >= Y_SIZE || z >= Z_SIZE) return null;

                return Blocks[y, x, z];
            }

            public void SetBlock(Block block, int x, int y, int z) {
                if(x < 0 || y < 0 || z < 0) return;
                if(x >= X_SIZE || y >= Y_SIZE || z >= Z_SIZE) return;

                byte chunkY = (byte) ((Id * Y_SIZE) + y);

                if(Parent.Heightmap[x, z].Item2 < chunkY || Parent.Heightmap[x, z] == default) {
                    Parent.Heightmap[x, z] = (true, chunkY, block.StateId);
                }

                Blocks[y, x, z] = block;
            }

            public bool IsEmpty() {
                int emptyCount = 0;

                Iterate(block => {
                    if(block == null) emptyCount++;
                });

                return emptyCount >= X_SIZE * Y_SIZE * Z_SIZE;
            }

            public void Iterate(Action<Block> action, bool flipXZ = false) {
                if(flipXZ) {
                    for(int y = 0; y < Y_SIZE; y++) {
                        for(int z = 0; z < Z_SIZE; z++) {
                            for(int x = 0; x < X_SIZE; x++) {
                                action(GetBlock(x, y, z));
                            }
                        }
                    }
                } else {
                    for(int y = 0; y < Y_SIZE; y++) {
                        for(int x = 0; x < X_SIZE; x++) {
                            for(int z = 0; z < Z_SIZE; z++) {
                                action(GetBlock(x, y, z));
                            }
                        }
                    }
                }
            }

            // TODO find a better way to do this
            // i probably won't even know what this does in a few days
            public long[] ToCompactedLongArray(int bitsPerBlock) {
                //                                   64 bits per long
                int blocksPerLong = (int) Math.Floor(64d / bitsPerBlock);

                //                       section size
                long[] array = new long[(16 * 16 * 16) / blocksPerLong];
                int longArrayIndex = array.Length - 1;
                byte longIndex = 0;

                Iterate(block => {
                    if(longIndex >= (bitsPerBlock * blocksPerLong)) {
                        longArrayIndex--;
                        longIndex = 0;
                    }

                    BitArray id = new((block == null ? (ushort) 0 : block.StateId).WriteLittleEndian());

                    bool[] bits = new bool[bitsPerBlock];
                    bool removing = true;

                    int k = 0;

                    // please don't ask me what this does because i don't even know
                    for(int j = id.Count - 1; j >= 0; j--) {
                        bool bit = id.Get(j);

                        if(removing) {
                            if(j - 1 < 0) break;

                            if(id.Get(j - 1)) {
                                removing = false;
                            }
                        } else {
                            if(k > 14 - 1) break;

                            bits[j] = bit;
                            k++;
                        }
                    }

                    Array.Reverse(bits);
                    id = new BitArray(bits);

                    for(int j = id.Count - 1; j >= 0; j--) {
                        if(id.Get(j)) {
                            array[longArrayIndex].SetBit(longIndex);
                        } else {
                            array[longArrayIndex].ClearBit(longIndex);
                        }

                        longIndex++;
                    }
                }, true);

                Array.Reverse(array); // reverse, otherwise the Y coordinate will be flipped
                return array;
            }
        }
    }
}
