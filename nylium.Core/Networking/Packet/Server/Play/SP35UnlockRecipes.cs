using nylium.Utilities;

namespace nylium.Core.Networking.Packet.Server.Play {

    [Packet(0x35, ProtocolState.Play, PacketSide.Server)]
    public class SP35UnlockRecipes : MinecraftPacket {

        public RecipeAction Action { get; }

        public bool CraftingRecipeBookOpen { get; }
        public bool CraftingRecipeBookFilterActive { get; }
        public bool SmeltingRecipeBookOpen { get; }
        public bool SmeltingRecipeBookFilterActive { get; }
        public bool BlastFurnaceRecipeBookOpen { get; }
        public bool BlastFurnaceRecipeBookFilterActive { get; }
        public bool SmokerRecipeBookOpen { get; }
        public bool SmokerRecipeBookFilterActive { get; }

        public Identifier[] RecipeIds { get; }
        public Identifier[] RecipeIdsInit { get; }

        public SP35UnlockRecipes(MinecraftClient client, RecipeAction action,
            bool craftingRecipeBookOpen, bool craftingRecipeBookFilterActive,
            bool smeltingRecipeBookOpen, bool smeltingRecipeBookFilterActive, bool blastFurnaceRecipeBookOpen,
            bool blastFurnaceRecipeBookFilterActive, bool smokerRecipeBookOpen, bool smokerRecipeBookFilterActive,
            Identifier[] recipeIds, Identifier[] recipeIdsInit = null) : base(client) {

            Action = (RecipeAction) Data.WriteVarInt((int) action);
            CraftingRecipeBookOpen = Data.WriteBoolean(craftingRecipeBookOpen);
            CraftingRecipeBookFilterActive = Data.WriteBoolean(craftingRecipeBookFilterActive);
            SmeltingRecipeBookOpen = Data.WriteBoolean(smeltingRecipeBookOpen);
            SmeltingRecipeBookFilterActive = Data.WriteBoolean(smeltingRecipeBookFilterActive);
            BlastFurnaceRecipeBookOpen = Data.WriteBoolean(blastFurnaceRecipeBookOpen);
            BlastFurnaceRecipeBookFilterActive = Data.WriteBoolean(blastFurnaceRecipeBookFilterActive);
            SmokerRecipeBookOpen = Data.WriteBoolean(smokerRecipeBookOpen);
            SmokerRecipeBookFilterActive = Data.WriteBoolean(smokerRecipeBookFilterActive);

            Data.WriteVarInt(recipeIds.Length);
            RecipeIds = Data.WriteArray<Identifier, DataTypes.Identifier>(recipeIds);

            if(action == RecipeAction.Init) {
                if(recipeIdsInit != null) {
                    Data.WriteVarInt(recipeIdsInit.Length);
                    RecipeIdsInit = Data.WriteArray<Identifier, DataTypes.Identifier>(recipeIdsInit);
                } else {
                    throw new System.ArgumentNullException(nameof(recipeIdsInit), "recipeIdsInit should be provided when action is init!");
                }
            }
        }

        public enum RecipeAction : int {

            Init,
            Add,
            Remove
        }
    }
}