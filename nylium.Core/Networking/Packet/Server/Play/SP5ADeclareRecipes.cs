using nylium.Core.Recipes;

namespace nylium.Core.Networking.Packet.Server.Play {

    [Packet(0x5A, ProtocolState.Play, PacketSide.Server)]
    public class SP5ADeclareRecipes : MinecraftPacket {

        public Recipe[] Recipes { get; }

        public SP5ADeclareRecipes(Recipe[] recipes) {
            Recipes = recipes;

            WriteVarInt(recipes.Length);
            WriteArray<Recipe, DataTypes.Recipe>(recipes);
        }
    }
}