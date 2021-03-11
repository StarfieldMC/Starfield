using System;
using nylium.Networking.DataTypes;
using U = nylium.Utilities;

namespace nylium.Networking.Packets.Server.Play {

    [Packet(0x5A, ProtocolState.Play, PacketSide.Server)]
    public class SP5ADeclareRecipes : Packet {

        public Recipe[] Recipes { get; }

        public SP5ADeclareRecipes(Recipe[] recipes) {
            Recipes = recipes;

            VarInt varInt = new(0); // hardcode for now
            varInt.Write(Data);

            // TODO array needs to be changed in a way so that it can also accept non-datatype values something idk aaaaaaa
            // Array<>
        }

        public class Recipe {

            public U.Identifier Type { get; set; }
            public U.Identifier Id { get; set; }
            public dynamic Data { get; set; }

            public Recipe(U.Identifier type, U.Identifier id, dynamic data) {
                Type = type;
                Id = id;
                Data = data;
            }
        }
    }
}