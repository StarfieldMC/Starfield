using System.IO;
using nylium.Core.Entity.Inventories;

namespace nylium.Core.Networking.DataTypes {

    public class Recipe : DataType<Recipes.Recipe> {

        public Recipe() : base(null) { }
        public Recipe(Recipes.Recipe value) : base(value) { }
        public Recipe(Stream stream) : base(null) { Read(stream); }

        public override void Read(Stream stream) {
            Identifier type = new(stream);
            Identifier id = new(stream);

            switch(type.Value.Id) {
                case "crafting_shapeless":
                    String group = new(stream);
                    VarInt ingredientCount = new(stream);
                    Array<Recipes.Recipe.Ingredient, Ingredient> ingredients = new(ingredientCount.Value, stream);
                    Slot result = new(stream);

                    Value = new(type.Value, id.Value, new {
                        Group = group.Value,
                        Ingredients = ingredients.Value,
                        Result = result.Value
                    });
                    break;
                case "crafting_shaped":
                    VarInt width = new(stream);
                    VarInt height = new(stream);
                    group = new(stream);
                    ingredients = new(width.Value * height.Value, stream);
                    result = new(stream);

                    Value = new(type.Value, id.Value, new {
                        Width = width.Value,
                        Height = height.Value,
                        Group = group.Value,
                        Ingredients = ingredients.Value,
                        Result = result.Value
                    });
                    break;
                case "smelting":
                case "blasting":
                case "smoking":
                case "campfire_cooking":
                    group = new(stream);
                    Ingredient ingredient = new(stream);
                    result = new(stream);
                    Float experience = new(stream);
                    VarInt cookingTime = new(stream);

                    Value = new(type.Value, id.Value, new {
                        Group = group.Value,
                        Ingredient = ingredient.Value,
                        Result = result.Value,
                        Experience = experience.Value,
                        CookingTime = cookingTime.Value
                    });
                    break;
                case "stonecutting":
                    group = new(stream);
                    ingredient = new(stream);
                    result = new(stream);

                    Value = new(type.Value, id.Value, new {
                        Group = group.Value,
                        Ingredient = ingredient.Value,
                        Result = result.Value,
                    });
                    break;
                case "smithing":
                    Ingredient @base = new(stream);
                    Ingredient addition = new(stream);
                    result = new(stream);

                    Value = new(type.Value, id.Value, new {
                        Base = @base.Value,
                        Addition = addition.Value,
                        Result = result.Value
                    });
                    break;
                default:
                    Value = new(type.Value, id.Value, new { });
                    break;
            }
        }

        public override void Write(Stream stream) {
            new Identifier(Value.Type).Write(stream);
            new Identifier(Value.Id).Write(stream);

            switch(Value.Type.Id) {
                case "crafting_shapeless":
                    new String(Value.Data.Group).Write(stream);
                    new VarInt(Value.Data.Ingredients.Length).Write(stream);
                    new Array<Recipes.Recipe.Ingredient, Ingredient>(Value.Data.Ingredients).Write(stream);
                    new Slot(Value.Data.Result).Write(stream);
                    break;
                case "crafting_shaped":
                    new VarInt(Value.Data.Width).Write(stream);
                    new VarInt(Value.Data.Height).Write(stream);
                    new String(Value.Data.Group).Write(stream);
                    new Array<Recipes.Recipe.Ingredient, Ingredient>(Value.Data.Ingredients).Write(stream);
                    new Slot(Value.Data.Result).Write(stream);
                    break;
                case "smelting":
                case "blasting":
                case "smoking":
                case "campfire_cooking":
                    new String(Value.Data.Group).Write(stream);
                    new Ingredient(Value.Data.Ingredient).Write(stream);
                    new Slot(Value.Data.Result).Write(stream);
                    new Float(Value.Data.Experience).Write(stream);
                    new VarInt(Value.Data.CookingTime).Write(stream);
                    break;
                case "stonecutting":
                    new String(Value.Data.Group).Write(stream);
                    new Ingredient(Value.Data.Ingredient).Write(stream);
                    new Slot(Value.Data.Result).Write(stream);
                    break;
                case "smithing":
                    new Ingredient(Value.Data.Base).Write(stream);
                    new Ingredient(Value.Data.Addition).Write(stream);
                    new Slot(Value.Data.Result).Write(stream);
                    break;
            }
        }

        public class Ingredient : DataType<Recipes.Recipe.Ingredient> {

            public Ingredient() : base(null) { }
            public Ingredient(Recipes.Recipe.Ingredient value) : base(value) { }
            public Ingredient(Stream stream) : base(null) { Read(stream); }

            public override void Read(Stream stream) {
                VarInt count = new(stream);
                Array<Inventory.Slot, Slot> items = new(count.Value, stream);

                Value = new(items.Value);
            }

            public override void Write(Stream stream) {
                new VarInt(Value.Items.Length).Write(stream);
                new Array<Inventory.Slot, Slot>(Value.Items).Write(stream);
            }
        }
    }
}