// FILE AUTOGENERATED. DO NOT MODIFY
using System;

namespace nylium.Core.Block.Blocks {

    public class BlockCampfire : BlockBase {

        public override string Id { get { return "minecraft:campfire"; } }

        public override ushort MinimumState { get { return 14898; } }
        public override ushort MaximumState { get { return 14929; } }
        public override ushort DefaultState { get { return 14901; } }

        public override ushort State {
            get {
                if(Facing == "north" && Lit == true && SignalFire == true && Waterlogged == true) {
                    return 14898;
                }

                if(Facing == "north" && Lit == true && SignalFire == true && Waterlogged == false) {
                    return 14899;
                }

                if(Facing == "north" && Lit == true && SignalFire == false && Waterlogged == true) {
                    return 14900;
                }

                if(Facing == "north" && Lit == true && SignalFire == false && Waterlogged == false) {
                    return 14901;
                }

                if(Facing == "north" && Lit == false && SignalFire == true && Waterlogged == true) {
                    return 14902;
                }

                if(Facing == "north" && Lit == false && SignalFire == true && Waterlogged == false) {
                    return 14903;
                }

                if(Facing == "north" && Lit == false && SignalFire == false && Waterlogged == true) {
                    return 14904;
                }

                if(Facing == "north" && Lit == false && SignalFire == false && Waterlogged == false) {
                    return 14905;
                }

                if(Facing == "south" && Lit == true && SignalFire == true && Waterlogged == true) {
                    return 14906;
                }

                if(Facing == "south" && Lit == true && SignalFire == true && Waterlogged == false) {
                    return 14907;
                }

                if(Facing == "south" && Lit == true && SignalFire == false && Waterlogged == true) {
                    return 14908;
                }

                if(Facing == "south" && Lit == true && SignalFire == false && Waterlogged == false) {
                    return 14909;
                }

                if(Facing == "south" && Lit == false && SignalFire == true && Waterlogged == true) {
                    return 14910;
                }

                if(Facing == "south" && Lit == false && SignalFire == true && Waterlogged == false) {
                    return 14911;
                }

                if(Facing == "south" && Lit == false && SignalFire == false && Waterlogged == true) {
                    return 14912;
                }

                if(Facing == "south" && Lit == false && SignalFire == false && Waterlogged == false) {
                    return 14913;
                }

                if(Facing == "west" && Lit == true && SignalFire == true && Waterlogged == true) {
                    return 14914;
                }

                if(Facing == "west" && Lit == true && SignalFire == true && Waterlogged == false) {
                    return 14915;
                }

                if(Facing == "west" && Lit == true && SignalFire == false && Waterlogged == true) {
                    return 14916;
                }

                if(Facing == "west" && Lit == true && SignalFire == false && Waterlogged == false) {
                    return 14917;
                }

                if(Facing == "west" && Lit == false && SignalFire == true && Waterlogged == true) {
                    return 14918;
                }

                if(Facing == "west" && Lit == false && SignalFire == true && Waterlogged == false) {
                    return 14919;
                }

                if(Facing == "west" && Lit == false && SignalFire == false && Waterlogged == true) {
                    return 14920;
                }

                if(Facing == "west" && Lit == false && SignalFire == false && Waterlogged == false) {
                    return 14921;
                }

                if(Facing == "east" && Lit == true && SignalFire == true && Waterlogged == true) {
                    return 14922;
                }

                if(Facing == "east" && Lit == true && SignalFire == true && Waterlogged == false) {
                    return 14923;
                }

                if(Facing == "east" && Lit == true && SignalFire == false && Waterlogged == true) {
                    return 14924;
                }

                if(Facing == "east" && Lit == true && SignalFire == false && Waterlogged == false) {
                    return 14925;
                }

                if(Facing == "east" && Lit == false && SignalFire == true && Waterlogged == true) {
                    return 14926;
                }

                if(Facing == "east" && Lit == false && SignalFire == true && Waterlogged == false) {
                    return 14927;
                }

                if(Facing == "east" && Lit == false && SignalFire == false && Waterlogged == true) {
                    return 14928;
                }

                if(Facing == "east" && Lit == false && SignalFire == false && Waterlogged == false) {
                    return 14929;
                }

                return DefaultState;
            }

            set {
                if(value == 14898) {
                    Facing = "north";
Lit = true;
SignalFire = true;
Waterlogged = true;
                }

                if(value == 14899) {
                    Facing = "north";
Lit = true;
SignalFire = true;
Waterlogged = false;
                }

                if(value == 14900) {
                    Facing = "north";
Lit = true;
SignalFire = false;
Waterlogged = true;
                }

                if(value == 14901) {
                    Facing = "north";
Lit = true;
SignalFire = false;
Waterlogged = false;
                }

                if(value == 14902) {
                    Facing = "north";
Lit = false;
SignalFire = true;
Waterlogged = true;
                }

                if(value == 14903) {
                    Facing = "north";
Lit = false;
SignalFire = true;
Waterlogged = false;
                }

                if(value == 14904) {
                    Facing = "north";
Lit = false;
SignalFire = false;
Waterlogged = true;
                }

                if(value == 14905) {
                    Facing = "north";
Lit = false;
SignalFire = false;
Waterlogged = false;
                }

                if(value == 14906) {
                    Facing = "south";
Lit = true;
SignalFire = true;
Waterlogged = true;
                }

                if(value == 14907) {
                    Facing = "south";
Lit = true;
SignalFire = true;
Waterlogged = false;
                }

                if(value == 14908) {
                    Facing = "south";
Lit = true;
SignalFire = false;
Waterlogged = true;
                }

                if(value == 14909) {
                    Facing = "south";
Lit = true;
SignalFire = false;
Waterlogged = false;
                }

                if(value == 14910) {
                    Facing = "south";
Lit = false;
SignalFire = true;
Waterlogged = true;
                }

                if(value == 14911) {
                    Facing = "south";
Lit = false;
SignalFire = true;
Waterlogged = false;
                }

                if(value == 14912) {
                    Facing = "south";
Lit = false;
SignalFire = false;
Waterlogged = true;
                }

                if(value == 14913) {
                    Facing = "south";
Lit = false;
SignalFire = false;
Waterlogged = false;
                }

                if(value == 14914) {
                    Facing = "west";
Lit = true;
SignalFire = true;
Waterlogged = true;
                }

                if(value == 14915) {
                    Facing = "west";
Lit = true;
SignalFire = true;
Waterlogged = false;
                }

                if(value == 14916) {
                    Facing = "west";
Lit = true;
SignalFire = false;
Waterlogged = true;
                }

                if(value == 14917) {
                    Facing = "west";
Lit = true;
SignalFire = false;
Waterlogged = false;
                }

                if(value == 14918) {
                    Facing = "west";
Lit = false;
SignalFire = true;
Waterlogged = true;
                }

                if(value == 14919) {
                    Facing = "west";
Lit = false;
SignalFire = true;
Waterlogged = false;
                }

                if(value == 14920) {
                    Facing = "west";
Lit = false;
SignalFire = false;
Waterlogged = true;
                }

                if(value == 14921) {
                    Facing = "west";
Lit = false;
SignalFire = false;
Waterlogged = false;
                }

                if(value == 14922) {
                    Facing = "east";
Lit = true;
SignalFire = true;
Waterlogged = true;
                }

                if(value == 14923) {
                    Facing = "east";
Lit = true;
SignalFire = true;
Waterlogged = false;
                }

                if(value == 14924) {
                    Facing = "east";
Lit = true;
SignalFire = false;
Waterlogged = true;
                }

                if(value == 14925) {
                    Facing = "east";
Lit = true;
SignalFire = false;
Waterlogged = false;
                }

                if(value == 14926) {
                    Facing = "east";
Lit = false;
SignalFire = true;
Waterlogged = true;
                }

                if(value == 14927) {
                    Facing = "east";
Lit = false;
SignalFire = true;
Waterlogged = false;
                }

                if(value == 14928) {
                    Facing = "east";
Lit = false;
SignalFire = false;
Waterlogged = true;
                }

                if(value == 14929) {
                    Facing = "east";
Lit = false;
SignalFire = false;
Waterlogged = false;
                }

            }
        }

        public string Facing { get; set; } = "north";
        public bool Lit { get; set; } = true;
        public bool SignalFire { get; set; } = false;
        public bool Waterlogged { get; set; } = false;

        public BlockCampfire() {
            State = DefaultState;
        }

        public BlockCampfire(ushort state) {
            if(state < MinimumState || state > MaximumState) {
                throw new ArgumentOutOfRangeException("state");
            }

            State = state;
        }

        public BlockCampfire(string facing, bool lit, bool signal_fire, bool waterlogged) {
            Facing = facing;
            Lit = lit;
            SignalFire = signal_fire;
            Waterlogged = waterlogged;
        }
    }
}