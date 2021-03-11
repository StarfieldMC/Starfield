using nylium.Networking.DataTypes;
using U = nylium.Utilities;

namespace nylium.Networking.Packets.Server.Play {

    [Packet(0x35, ProtocolState.Play, PacketSide.Server)]
    public class SP35UnlockRecipes : Packet {

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

            VarInt varInt = new((int) Action);
            varInt.Write(Data);

            Boolean boolean = new(craftingRecipeBookOpen);
            boolean.Write(Data);

            boolean.Value = craftingRecipeBookFilterActive;
            boolean.Write(Data);

            boolean.Value = smeltingRecipeBookOpen;
            boolean.Write(Data);

            boolean.Value = smeltingRecipeBookFilterActive;
            boolean.Write(Data);

            boolean.Value = blastFurnaceRecipeBookOpen;
            boolean.Write(Data);

            boolean.Value = blastFurnaceRecipeBookFilterActive;
            boolean.Write(Data);

            boolean.Value = smokerRecipeBookOpen;
            boolean.Write(Data);

            boolean.Value = smokerRecipeBookFilterActive;
            boolean.Write(Data);

            varInt.Value = recipeIds.Length;
            varInt.Write(Data);

            Array<U.Identifier, Identifier> array = new(recipeIds);
            array.Write(Data);

            if(action == RecipeAction.Init) {
                if(recipeIdsInit != null) {
                    varInt.Value = recipeIdsInit.Length;
                    varInt.Write(Data);

                    array = new(recipeIdsInit);
                    array.Write(Data);
                } else {
                    throw new System.ArgumentNullException("recipeIdsInit", "recipeIdsInit should be provided when action is init!");
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