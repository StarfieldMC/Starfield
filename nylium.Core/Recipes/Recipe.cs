using System;
using System.Dynamic;
using nylium.Core.Entity.Inventory;
using nylium.Utilities;

namespace nylium.Core.Recipes {

    public class Recipe {

        public Identifier Type { get; }
        public Identifier Id { get; }
        public dynamic Data { get; }

        public Recipe(Identifier type, Identifier id, dynamic data) {
            Type = type;
            Id = id;
            Data = data;
        }

        public class Ingredient {

            public Inventory.Slot[] Items { get; }

            public Ingredient(params Inventory.Slot[] items) {
                Items = items;
            }
        }
    }
}