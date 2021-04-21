// AUTOGENERATED. DO NOT MODIFY
using nylium.Core.Level;

namespace nylium.Core.Block.Blocks {

    public class MushroomStemBlock : BaseBlock {

        public bool Down { get; }
        public bool East { get; }
        public bool North { get; }
        public bool South { get; }
        public bool Up { get; }
        public bool West { get; }

        public MushroomStemBlock(Chunk chunk, int x, int y, int z) : base(chunk, x, y, z, 240, 4633) { }

        public MushroomStemBlock(Chunk chunk, int x, int y, int z, ushort state) : base(chunk, x, y, z 240, state) {
            if(state == 4633) {
                Down = true;
                East = true;
                North = true;
                South = true;
                Up = true;
                West = true;
            } else if(state == 4634) {
                Down = true;
                East = true;
                North = true;
                South = true;
                Up = true;
                West = false;
            } else if(state == 4635) {
                Down = true;
                East = true;
                North = true;
                South = true;
                Up = false;
                West = true;
            } else if(state == 4636) {
                Down = true;
                East = true;
                North = true;
                South = true;
                Up = false;
                West = false;
            } else if(state == 4637) {
                Down = true;
                East = true;
                North = true;
                South = false;
                Up = true;
                West = true;
            } else if(state == 4638) {
                Down = true;
                East = true;
                North = true;
                South = false;
                Up = true;
                West = false;
            } else if(state == 4639) {
                Down = true;
                East = true;
                North = true;
                South = false;
                Up = false;
                West = true;
            } else if(state == 4640) {
                Down = true;
                East = true;
                North = true;
                South = false;
                Up = false;
                West = false;
            } else if(state == 4641) {
                Down = true;
                East = true;
                North = false;
                South = true;
                Up = true;
                West = true;
            } else if(state == 4642) {
                Down = true;
                East = true;
                North = false;
                South = true;
                Up = true;
                West = false;
            } else if(state == 4643) {
                Down = true;
                East = true;
                North = false;
                South = true;
                Up = false;
                West = true;
            } else if(state == 4644) {
                Down = true;
                East = true;
                North = false;
                South = true;
                Up = false;
                West = false;
            } else if(state == 4645) {
                Down = true;
                East = true;
                North = false;
                South = false;
                Up = true;
                West = true;
            } else if(state == 4646) {
                Down = true;
                East = true;
                North = false;
                South = false;
                Up = true;
                West = false;
            } else if(state == 4647) {
                Down = true;
                East = true;
                North = false;
                South = false;
                Up = false;
                West = true;
            } else if(state == 4648) {
                Down = true;
                East = true;
                North = false;
                South = false;
                Up = false;
                West = false;
            } else if(state == 4649) {
                Down = true;
                East = false;
                North = true;
                South = true;
                Up = true;
                West = true;
            } else if(state == 4650) {
                Down = true;
                East = false;
                North = true;
                South = true;
                Up = true;
                West = false;
            } else if(state == 4651) {
                Down = true;
                East = false;
                North = true;
                South = true;
                Up = false;
                West = true;
            } else if(state == 4652) {
                Down = true;
                East = false;
                North = true;
                South = true;
                Up = false;
                West = false;
            } else if(state == 4653) {
                Down = true;
                East = false;
                North = true;
                South = false;
                Up = true;
                West = true;
            } else if(state == 4654) {
                Down = true;
                East = false;
                North = true;
                South = false;
                Up = true;
                West = false;
            } else if(state == 4655) {
                Down = true;
                East = false;
                North = true;
                South = false;
                Up = false;
                West = true;
            } else if(state == 4656) {
                Down = true;
                East = false;
                North = true;
                South = false;
                Up = false;
                West = false;
            } else if(state == 4657) {
                Down = true;
                East = false;
                North = false;
                South = true;
                Up = true;
                West = true;
            } else if(state == 4658) {
                Down = true;
                East = false;
                North = false;
                South = true;
                Up = true;
                West = false;
            } else if(state == 4659) {
                Down = true;
                East = false;
                North = false;
                South = true;
                Up = false;
                West = true;
            } else if(state == 4660) {
                Down = true;
                East = false;
                North = false;
                South = true;
                Up = false;
                West = false;
            } else if(state == 4661) {
                Down = true;
                East = false;
                North = false;
                South = false;
                Up = true;
                West = true;
            } else if(state == 4662) {
                Down = true;
                East = false;
                North = false;
                South = false;
                Up = true;
                West = false;
            } else if(state == 4663) {
                Down = true;
                East = false;
                North = false;
                South = false;
                Up = false;
                West = true;
            } else if(state == 4664) {
                Down = true;
                East = false;
                North = false;
                South = false;
                Up = false;
                West = false;
            } else if(state == 4665) {
                Down = false;
                East = true;
                North = true;
                South = true;
                Up = true;
                West = true;
            } else if(state == 4666) {
                Down = false;
                East = true;
                North = true;
                South = true;
                Up = true;
                West = false;
            } else if(state == 4667) {
                Down = false;
                East = true;
                North = true;
                South = true;
                Up = false;
                West = true;
            } else if(state == 4668) {
                Down = false;
                East = true;
                North = true;
                South = true;
                Up = false;
                West = false;
            } else if(state == 4669) {
                Down = false;
                East = true;
                North = true;
                South = false;
                Up = true;
                West = true;
            } else if(state == 4670) {
                Down = false;
                East = true;
                North = true;
                South = false;
                Up = true;
                West = false;
            } else if(state == 4671) {
                Down = false;
                East = true;
                North = true;
                South = false;
                Up = false;
                West = true;
            } else if(state == 4672) {
                Down = false;
                East = true;
                North = true;
                South = false;
                Up = false;
                West = false;
            } else if(state == 4673) {
                Down = false;
                East = true;
                North = false;
                South = true;
                Up = true;
                West = true;
            } else if(state == 4674) {
                Down = false;
                East = true;
                North = false;
                South = true;
                Up = true;
                West = false;
            } else if(state == 4675) {
                Down = false;
                East = true;
                North = false;
                South = true;
                Up = false;
                West = true;
            } else if(state == 4676) {
                Down = false;
                East = true;
                North = false;
                South = true;
                Up = false;
                West = false;
            } else if(state == 4677) {
                Down = false;
                East = true;
                North = false;
                South = false;
                Up = true;
                West = true;
            } else if(state == 4678) {
                Down = false;
                East = true;
                North = false;
                South = false;
                Up = true;
                West = false;
            } else if(state == 4679) {
                Down = false;
                East = true;
                North = false;
                South = false;
                Up = false;
                West = true;
            } else if(state == 4680) {
                Down = false;
                East = true;
                North = false;
                South = false;
                Up = false;
                West = false;
            } else if(state == 4681) {
                Down = false;
                East = false;
                North = true;
                South = true;
                Up = true;
                West = true;
            } else if(state == 4682) {
                Down = false;
                East = false;
                North = true;
                South = true;
                Up = true;
                West = false;
            } else if(state == 4683) {
                Down = false;
                East = false;
                North = true;
                South = true;
                Up = false;
                West = true;
            } else if(state == 4684) {
                Down = false;
                East = false;
                North = true;
                South = true;
                Up = false;
                West = false;
            } else if(state == 4685) {
                Down = false;
                East = false;
                North = true;
                South = false;
                Up = true;
                West = true;
            } else if(state == 4686) {
                Down = false;
                East = false;
                North = true;
                South = false;
                Up = true;
                West = false;
            } else if(state == 4687) {
                Down = false;
                East = false;
                North = true;
                South = false;
                Up = false;
                West = true;
            } else if(state == 4688) {
                Down = false;
                East = false;
                North = true;
                South = false;
                Up = false;
                West = false;
            } else if(state == 4689) {
                Down = false;
                East = false;
                North = false;
                South = true;
                Up = true;
                West = true;
            } else if(state == 4690) {
                Down = false;
                East = false;
                North = false;
                South = true;
                Up = true;
                West = false;
            } else if(state == 4691) {
                Down = false;
                East = false;
                North = false;
                South = true;
                Up = false;
                West = true;
            } else if(state == 4692) {
                Down = false;
                East = false;
                North = false;
                South = true;
                Up = false;
                West = false;
            } else if(state == 4693) {
                Down = false;
                East = false;
                North = false;
                South = false;
                Up = true;
                West = true;
            } else if(state == 4694) {
                Down = false;
                East = false;
                North = false;
                South = false;
                Up = true;
                West = false;
            } else if(state == 4695) {
                Down = false;
                East = false;
                North = false;
                South = false;
                Up = false;
                West = true;
            } else if(state == 4696) {
                Down = false;
                East = false;
                North = false;
                South = false;
                Up = false;
                West = false;
            }
        }

        public MushroomStemBlock(Chunk chunk, int x, int y, int z, bool down, bool east, bool north, bool south, bool up, bool west) : base(chunk, x, y, z, 240, 4633) {
if(down == true && east == true && north == true && south == true && up == true && west == true) {
                State = 4633;
            } else if(down == true && east == true && north == true && south == true && up == true && west == false) {
                State = 4634;
            } else if(down == true && east == true && north == true && south == true && up == false && west == true) {
                State = 4635;
            } else if(down == true && east == true && north == true && south == true && up == false && west == false) {
                State = 4636;
            } else if(down == true && east == true && north == true && south == false && up == true && west == true) {
                State = 4637;
            } else if(down == true && east == true && north == true && south == false && up == true && west == false) {
                State = 4638;
            } else if(down == true && east == true && north == true && south == false && up == false && west == true) {
                State = 4639;
            } else if(down == true && east == true && north == true && south == false && up == false && west == false) {
                State = 4640;
            } else if(down == true && east == true && north == false && south == true && up == true && west == true) {
                State = 4641;
            } else if(down == true && east == true && north == false && south == true && up == true && west == false) {
                State = 4642;
            } else if(down == true && east == true && north == false && south == true && up == false && west == true) {
                State = 4643;
            } else if(down == true && east == true && north == false && south == true && up == false && west == false) {
                State = 4644;
            } else if(down == true && east == true && north == false && south == false && up == true && west == true) {
                State = 4645;
            } else if(down == true && east == true && north == false && south == false && up == true && west == false) {
                State = 4646;
            } else if(down == true && east == true && north == false && south == false && up == false && west == true) {
                State = 4647;
            } else if(down == true && east == true && north == false && south == false && up == false && west == false) {
                State = 4648;
            } else if(down == true && east == false && north == true && south == true && up == true && west == true) {
                State = 4649;
            } else if(down == true && east == false && north == true && south == true && up == true && west == false) {
                State = 4650;
            } else if(down == true && east == false && north == true && south == true && up == false && west == true) {
                State = 4651;
            } else if(down == true && east == false && north == true && south == true && up == false && west == false) {
                State = 4652;
            } else if(down == true && east == false && north == true && south == false && up == true && west == true) {
                State = 4653;
            } else if(down == true && east == false && north == true && south == false && up == true && west == false) {
                State = 4654;
            } else if(down == true && east == false && north == true && south == false && up == false && west == true) {
                State = 4655;
            } else if(down == true && east == false && north == true && south == false && up == false && west == false) {
                State = 4656;
            } else if(down == true && east == false && north == false && south == true && up == true && west == true) {
                State = 4657;
            } else if(down == true && east == false && north == false && south == true && up == true && west == false) {
                State = 4658;
            } else if(down == true && east == false && north == false && south == true && up == false && west == true) {
                State = 4659;
            } else if(down == true && east == false && north == false && south == true && up == false && west == false) {
                State = 4660;
            } else if(down == true && east == false && north == false && south == false && up == true && west == true) {
                State = 4661;
            } else if(down == true && east == false && north == false && south == false && up == true && west == false) {
                State = 4662;
            } else if(down == true && east == false && north == false && south == false && up == false && west == true) {
                State = 4663;
            } else if(down == true && east == false && north == false && south == false && up == false && west == false) {
                State = 4664;
            } else if(down == false && east == true && north == true && south == true && up == true && west == true) {
                State = 4665;
            } else if(down == false && east == true && north == true && south == true && up == true && west == false) {
                State = 4666;
            } else if(down == false && east == true && north == true && south == true && up == false && west == true) {
                State = 4667;
            } else if(down == false && east == true && north == true && south == true && up == false && west == false) {
                State = 4668;
            } else if(down == false && east == true && north == true && south == false && up == true && west == true) {
                State = 4669;
            } else if(down == false && east == true && north == true && south == false && up == true && west == false) {
                State = 4670;
            } else if(down == false && east == true && north == true && south == false && up == false && west == true) {
                State = 4671;
            } else if(down == false && east == true && north == true && south == false && up == false && west == false) {
                State = 4672;
            } else if(down == false && east == true && north == false && south == true && up == true && west == true) {
                State = 4673;
            } else if(down == false && east == true && north == false && south == true && up == true && west == false) {
                State = 4674;
            } else if(down == false && east == true && north == false && south == true && up == false && west == true) {
                State = 4675;
            } else if(down == false && east == true && north == false && south == true && up == false && west == false) {
                State = 4676;
            } else if(down == false && east == true && north == false && south == false && up == true && west == true) {
                State = 4677;
            } else if(down == false && east == true && north == false && south == false && up == true && west == false) {
                State = 4678;
            } else if(down == false && east == true && north == false && south == false && up == false && west == true) {
                State = 4679;
            } else if(down == false && east == true && north == false && south == false && up == false && west == false) {
                State = 4680;
            } else if(down == false && east == false && north == true && south == true && up == true && west == true) {
                State = 4681;
            } else if(down == false && east == false && north == true && south == true && up == true && west == false) {
                State = 4682;
            } else if(down == false && east == false && north == true && south == true && up == false && west == true) {
                State = 4683;
            } else if(down == false && east == false && north == true && south == true && up == false && west == false) {
                State = 4684;
            } else if(down == false && east == false && north == true && south == false && up == true && west == true) {
                State = 4685;
            } else if(down == false && east == false && north == true && south == false && up == true && west == false) {
                State = 4686;
            } else if(down == false && east == false && north == true && south == false && up == false && west == true) {
                State = 4687;
            } else if(down == false && east == false && north == true && south == false && up == false && west == false) {
                State = 4688;
            } else if(down == false && east == false && north == false && south == true && up == true && west == true) {
                State = 4689;
            } else if(down == false && east == false && north == false && south == true && up == true && west == false) {
                State = 4690;
            } else if(down == false && east == false && north == false && south == true && up == false && west == true) {
                State = 4691;
            } else if(down == false && east == false && north == false && south == true && up == false && west == false) {
                State = 4692;
            } else if(down == false && east == false && north == false && south == false && up == true && west == true) {
                State = 4693;
            } else if(down == false && east == false && north == false && south == false && up == true && west == false) {
                State = 4694;
            } else if(down == false && east == false && north == false && south == false && up == false && west == true) {
                State = 4695;
            } else if(down == false && east == false && north == false && south == false && up == false && west == false) {
                State = 4696;
            }
        }
    }
}
