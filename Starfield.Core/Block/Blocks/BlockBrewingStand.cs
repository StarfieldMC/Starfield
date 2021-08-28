// FILE AUTOGENERATED. DO NOT MODIFY
using System;

namespace Starfield.Core.Block.Blocks {

    [Block("minecraft:brewing_stand", 260, 5137, 5144, 5144)]
    public class BlockBrewingStand : BlockBase {

        public override ushort State {
            get {
                if(HasBottle0 == true && HasBottle1 == true && HasBottle2 == true) {
                    return 5137;
                }

                if(HasBottle0 == true && HasBottle1 == true && HasBottle2 == false) {
                    return 5138;
                }

                if(HasBottle0 == true && HasBottle1 == false && HasBottle2 == true) {
                    return 5139;
                }

                if(HasBottle0 == true && HasBottle1 == false && HasBottle2 == false) {
                    return 5140;
                }

                if(HasBottle0 == false && HasBottle1 == true && HasBottle2 == true) {
                    return 5141;
                }

                if(HasBottle0 == false && HasBottle1 == true && HasBottle2 == false) {
                    return 5142;
                }

                if(HasBottle0 == false && HasBottle1 == false && HasBottle2 == true) {
                    return 5143;
                }

                if(HasBottle0 == false && HasBottle1 == false && HasBottle2 == false) {
                    return 5144;
                }

                return DefaultState;
            }

            set {
                if(value == 5137) {
                    HasBottle0 = true;
HasBottle1 = true;
HasBottle2 = true;
                }

                if(value == 5138) {
                    HasBottle0 = true;
HasBottle1 = true;
HasBottle2 = false;
                }

                if(value == 5139) {
                    HasBottle0 = true;
HasBottle1 = false;
HasBottle2 = true;
                }

                if(value == 5140) {
                    HasBottle0 = true;
HasBottle1 = false;
HasBottle2 = false;
                }

                if(value == 5141) {
                    HasBottle0 = false;
HasBottle1 = true;
HasBottle2 = true;
                }

                if(value == 5142) {
                    HasBottle0 = false;
HasBottle1 = true;
HasBottle2 = false;
                }

                if(value == 5143) {
                    HasBottle0 = false;
HasBottle1 = false;
HasBottle2 = true;
                }

                if(value == 5144) {
                    HasBottle0 = false;
HasBottle1 = false;
HasBottle2 = false;
                }

            }
        }

        public bool HasBottle0 { get; set; } = false;
        public bool HasBottle1 { get; set; } = false;
        public bool HasBottle2 { get; set; } = false;

        public BlockBrewingStand() {
            State = DefaultState;
        }

        public BlockBrewingStand(ushort state) : base(state) {
            if(state < MinimumState || state > MaximumState) {
                throw new ArgumentOutOfRangeException("state");
            }

            State = state;
        }

        public BlockBrewingStand(bool has_bottle_0, bool has_bottle_1, bool has_bottle_2) {
            HasBottle0 = has_bottle_0;
            HasBottle1 = has_bottle_1;
            HasBottle2 = has_bottle_2;
        }
    }
}