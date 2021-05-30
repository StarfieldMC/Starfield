using System;

namespace nylium.Core.Blocks {
    public class Test : BlockBase {

        static Test() {
            Id = "poo";
            DefaultState = 3984;
        }

        public Test(dynamic prop) : base((object) prop) { }
    }
}