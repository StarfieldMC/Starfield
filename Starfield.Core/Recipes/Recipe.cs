using System;
using System.Dynamic;
using Starfield.Utilities;
using Starfield.Core.Entity.Inventories;

namespace Starfield.Core.Recipes {

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