using nylium.Core.DataTypes;
using U = nylium.Utilities;

namespace nylium.Core.Packet.Server.Play {

    [Packet(0x35, ProtocolState.Play, PacketSide.Server)]
    public class SP35UnlockRecipes : NetworkPacket {

        public RecipeAction Action { get; }

        public bool CraftingRecipeBookOpen { get; }
        public bool CraftingRecipeBookFilterActive { get; }
        public bool SmeltingRecipeBookOpen { get; }
        public bool SmeltingRecipeBookFilterActive { get; }
        public bool BlastFurnaceRecipeBookOpen { get; }
        public bool BlastFurnaceRecipeBookFilterActive { get; }
        public bool SmokerRecipeBookOpen { get; }
        public bool SmokerRecipeBookFilterActive { get; }

        public U.Identifier[] RecipeIds { get; }
        public U.Identifier[] RecipeIdsInit { get; }

        public SP35UnlockRecipes(RecipeAction action, bool craftingRecipeBookOpen, bool craftingRecipeBookFilterActive,
            bool smeltingRecipeBookOpen, bool smeltingRecipeBookFilterActive, bool blastFurnaceRecipeBookOpen,
            bool blastFurnaceRecipeBookFilterActive, bool smokerRecipeBookOpen, bool smokerRecipeBookFilterActive,
            U.Identifier[] recipeIds, U.Identifier[] recipeIdsInit = null) {

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

            Array<U.Identifier, Identifier> array = new(recipeIds);
            array.Write(Data);

            if(action == RecipeAction.Init) {
                if(recipeIdsInit != null) {
                    WriteVarInt(recipeIdsInit.Length);

                    array = new(recipeIdsInit);
                    array.Write(Data);
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