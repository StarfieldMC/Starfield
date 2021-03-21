using System;
using nylium.Core.DataTypes;
using U = nylium.Utilities;

namespace nylium.Core.Networking.Packet.Server.Play {

    [Packet(0x5A, ProtocolState.Play, PacketSide.Server)]
    public class SP5ADeclareRecipes : NetworkPacket {

        public Recipe[] Recipes { get; }

        // TODO
        public SP5ADeclareRecipes(Recipe[] recipes) {
            Recipes = recipes;

            WriteVarInt(0); // hardcode for now
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