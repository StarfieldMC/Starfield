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

        public SP35UnlockRecipes(RecipeAction action, bool craftingRecipeBookOpen, bool craftingRecipeBookFilterActive,
            bool smeltingRecipeBookOpen, bool smeltingRecipeBookFilterActive, bool blastFurnaceRecipeBookOpen,
            bool blastFurnaceRecipeBookFilterActive, bool smokerRecipeBookOpen, bool smokerRecipeBookFilterActive,
            Identifier[] recipeIds, Identifier[] recipeIdsInit = null) {

            Action = action;
            CraftingRecipeBookOpen = craftingRecipeBookOpen;
            CraftingRecipeBookFilterActive = craftingRecipeBookFilterActive;
            SmeltingRecipeBookOpen = smeltingRecipeBookOpen;
            SmeltingRecipeBookFilterActive = smeltingRecipeBookFilterActive;
            BlastFurnaceRecipeBookOpen = blastFurnaceRecipeBookOpen;
            BlastFurnaceRecipeBookFilterActive = blastFurnaceRecipeBookFilterActive;
            SmokerRecipeBookOpen = smokerRecipeBookOpen;
            SmokerRecipeBookFilterActive = smokerRecipeBookFilterActive;

            WriteVarInt((int) action);

            WriteBoolean(craftingRecipeBookOpen);
            WriteBoolean(craftingRecipeBookFilterActive);
            WriteBoolean(smeltingRecipeBookOpen);
            WriteBoolean(smeltingRecipeBookFilterActive);
            WriteBoolean(blastFurnaceRecipeBookOpen);
            WriteBoolean(blastFurnaceRecipeBookFilterActive);
            WriteBoolean(smokerRecipeBookOpen);
            WriteBoolean(smokerRecipeBookFilterActive);

            WriteVarInt(recipeIds.Length);
            WriteArray<Identifier, DataTypes.Identifier>(recipeIds);

            if(action == RecipeAction.Init) {
                if(recipeIdsInit != null) {
                    WriteVarInt(recipeIdsInit.Length);
                    WriteArray<Identifier, DataTypes.Identifier>(recipeIdsInit);
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