using Starfield.Core.Recipes;

namespace Starfield.Core.Networking.Packet.Server.Play {

    [Packet(0x5A, ProtocolState.Play, PacketSide.Server)]
    public class SP5ADeclareRecipes : MinecraftPacket {

        public Recipe[] Recipes { get; }

        public SP5ADeclareRecipes(MinecraftClient client, Recipe[] recipes) : base(client) {
            Data.WriteVarInt(recipes.Length);
            Recipes = Data.WriteArray<Recipe, DataTypes.Recipe>(recipes);
        }
    }
}