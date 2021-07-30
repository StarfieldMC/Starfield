// FILE AUTOGENERATED. DO NOT MODIFY
using System;

namespace nylium.Core.Block.Blocks {

    public class BlockSeaPickle : BlockBase {

        public override string Id { get { return "minecraft:sea_pickle"; } }

        public override ushort MinimumState { get { return 9644; } }
        public override ushort MaximumState { get { return 9651; } }
        public override ushort DefaultState { get { return 9644; } }

        public override ushort State {
            get {
                if(Pickles == 1 && Waterlogged == true) {
                    return 9644;
                }

                if(Pickles == 1 && Waterlogged == false) {
                    return 9645;
                }

                if(Pickles == 2 && Waterlogged == true) {
                    return 9646;
                }

                if(Pickles == 2 && Waterlogged == false) {
                    return 9647;
                }

                if(Pickles == 3 && Waterlogged == true) {
                    return 9648;
                }

                if(Pickles == 3 && Waterlogged == false) {
                    return 9649;
                }

                if(Pickles == 4 && Waterlogged == true) {
                    return 9650;
                }

                if(Pickles == 4 && Waterlogged == false) {
                    return 9651;
                }

                return DefaultState;
            }

            set {
                if(value == 9644) {
                    Pickles = 1;
Waterlogged = true;
                }

                if(value == 9645) {
                    Pickles = 1;
Waterlogged = false;
                }

                if(value == 9646) {
                    Pickles = 2;
Waterlogged = true;
                }

                if(value == 9647) {
                    Pickles = 2;
Waterlogged = false;
                }

                if(value == 9648) {
                    Pickles = 3;
Waterlogged = true;
                }

                if(value == 9649) {
                    Pickles = 3;
Waterlogged = false;
                }

                if(value == 9650) {
                    Pickles = 4;
Waterlogged = true;
                }

                if(value == 9651) {
                    Pickles = 4;
Waterlogged = false;
                }

            }
        }

        public int Pickles { get; set; } = 1;
        public bool Waterlogged { get; set; } = true;

        public BlockSeaPickle() {
            State = DefaultState;
        }

        public BlockSeaPickle(ushort state) {
            if(state < MinimumState || state > MaximumState) {
                throw new ArgumentOutOfRangeException("state");
            }

            State = state;
        }

        public BlockSeaPickle(int pickles, bool waterlogged) {
            Pickles = pickles;
            Waterlogged = waterlogged;
        }
    }
}