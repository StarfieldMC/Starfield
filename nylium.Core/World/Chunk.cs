using System;
using System.Diagnostics;
using nylium.Core.Block;

namespace nylium.Core.World {

    public class Chunk {

        public const int X_SIZE = 16;
        public const int Z_SIZE = 16;
        public const int Y_SIZE = 256;
        public const int SECTION_COUNT = Y_SIZE / Section.Y_SIZE;

        public GameWorld Parent { get; }

        public int X { get; }
        public int Z { get; }

        private Section[] Sections { get; }

        public Chunk(GameWorld parent, int x, int z) {
            Parent = parent;

            X = x;
            Z = z;

            Sections = new Section[SECTION_COUNT];
        }

        public Chunk(GameWorld parent, int x, int z, Section[] sections) {
            Parent = parent;

            X = x;
            Z = z;

            if(sections.Length > SECTION_COUNT) throw new ArgumentException($"There can't be more sections than {SECTION_COUNT}!");
            else if(sections.Length < SECTION_COUNT) Array.Resize(ref sections, SECTION_COUNT);

            Sections = sections;
        }

        public Section GetSection(int id) {
            return Sections[id];
        }

        public void SetSection(Section section, int id) {
            Sections[id] = section;
        }

        public GameBlock GetBlock(int x, int y, int z) {
            int id = (int) Math.Floor((double) y / Section.Y_SIZE);
            if(Sections[id] == null) return null;

            y -= (id * Section.Y_SIZE);
            return Sections[id].GetBlock(x, y, z);
        }

        public void SetBlock(GameBlock block, int x, int y, int z) {
            int id = (int) Math.Floor((double) y / Section.Y_SIZE);

            if(Sections[id] == null) Sections[id] = new(id, this);

            y -= (id * Section.Y_SIZE);
            Sections[id].SetBlock(block, x, y, z);
        }

        public class Section {

            public const int X_SIZE = 16;
            public const int Z_SIZE = 16;
            public const int Y_SIZE = 16;

            public int Id { get; }
            public Chunk Parent { get; }
            private GameBlock[,,] Blocks { get; }

            public Section(int id, Chunk parent) {
                Id = id;
                Parent = parent;
                Blocks = new GameBlock[Y_SIZE, X_SIZE, Z_SIZE];
            }

            public Section(int id, Chunk parent, GameBlock[,,] blocks) {
                Id = id;
                Parent = parent;
                Blocks = blocks;
            }

            public GameBlock GetBlock(int x, int y, int z) {
                return Blocks[y, x, z];
            }

            public void SetBlock(GameBlock block, int x, int y, int z) {
                Blocks[y, x, z] = block;
            }

            public void Iterate(Action<GameBlock> action, bool flipXZ = false) {
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
        }
    }
}
