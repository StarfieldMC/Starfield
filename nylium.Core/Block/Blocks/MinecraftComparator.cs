// FILE AUTOGENERATED. DO NOT MODIFY
using System;

namespace nylium.Core.Block.Blocks {

    public class BlockComparator : BlockBase {

        public override string Id { get { return "minecraft:comparator"; } }

        public override ushort MinimumState { get { return 6682; } }
        public override ushort MaximumState { get { return 6697; } }
        public override ushort DefaultState { get { return 6683; } }

        public override ushort State {
            get {
                if(Facing == "north" && Mode == "compare" && Powered == true) {
                    return 6682;
                }

                if(Facing == "north" && Mode == "compare" && Powered == false) {
                    return 6683;
                }

                if(Facing == "north" && Mode == "subtract" && Powered == true) {
                    return 6684;
                }

                if(Facing == "north" && Mode == "subtract" && Powered == false) {
                    return 6685;
                }

                if(Facing == "south" && Mode == "compare" && Powered == true) {
                    return 6686;
                }

                if(Facing == "south" && Mode == "compare" && Powered == false) {
                    return 6687;
                }

                if(Facing == "south" && Mode == "subtract" && Powered == true) {
                    return 6688;
                }

                if(Facing == "south" && Mode == "subtract" && Powered == false) {
                    return 6689;
                }

                if(Facing == "west" && Mode == "compare" && Powered == true) {
                    return 6690;
                }

                if(Facing == "west" && Mode == "compare" && Powered == false) {
                    return 6691;
                }

                if(Facing == "west" && Mode == "subtract" && Powered == true) {
                    return 6692;
                }

                if(Facing == "west" && Mode == "subtract" && Powered == false) {
                    return 6693;
                }

                if(Facing == "east" && Mode == "compare" && Powered == true) {
                    return 6694;
                }

                if(Facing == "east" && Mode == "compare" && Powered == false) {
                    return 6695;
                }

                if(Facing == "east" && Mode == "subtract" && Powered == true) {
                    return 6696;
                }

                if(Facing == "east" && Mode == "subtract" && Powered == false) {
                    return 6697;
                }

                return DefaultState;
            }

            set {
                if(value == 6682) {
                    Facing = "north";
Mode = "compare";
Powered = true;
                }

                if(value == 6683) {
                    Facing = "north";
Mode = "compare";
Powered = false;
                }

                if(value == 6684) {
                    Facing = "north";
Mode = "subtract";
Powered = true;
                }

                if(value == 6685) {
                    Facing = "north";
Mode = "subtract";
Powered = false;
                }

                if(value == 6686) {
                    Facing = "south";
Mode = "compare";
Powered = true;
                }

                if(value == 6687) {
                    Facing = "south";
Mode = "compare";
Powered = false;
                }

                if(value == 6688) {
                    Facing = "south";
Mode = "subtract";
Powered = true;
                }

                if(value == 6689) {
                    Facing = "south";
Mode = "subtract";
Powered = false;
                }

                if(value == 6690) {
                    Facing = "west";
Mode = "compare";
Powered = true;
                }

                if(value == 6691) {
                    Facing = "west";
Mode = "compare";
Powered = false;
                }

                if(value == 6692) {
                    Facing = "west";
Mode = "subtract";
Powered = true;
                }

                if(value == 6693) {
                    Facing = "west";
Mode = "subtract";
Powered = false;
                }

                if(value == 6694) {
                    Facing = "east";
Mode = "compare";
Powered = true;
                }

                if(value == 6695) {
                    Facing = "east";
Mode = "compare";
Powered = false;
                }

                if(value == 6696) {
                    Facing = "east";
Mode = "subtract";
Powered = true;
                }

                if(value == 6697) {
                    Facing = "east";
Mode = "subtract";
Powered = false;
                }

            }
        }

        public string Facing { get; set; } = "north";
        public string Mode { get; set; } = "compare";
        public bool Powered { get; set; } = false;

        public BlockComparator() {
            State = DefaultState;
        }

        public BlockComparator(ushort state) {
            if(state < MinimumState || state > MaximumState) {
                throw new ArgumentOutOfRangeException("state");
            }

            State = state;
        }

        public BlockComparator(string facing, string mode, bool powered) {
            Facing = facing;
            Mode = mode;
            Powered = powered;
        }
    }
}