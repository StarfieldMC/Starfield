using System;
using System.Collections.Generic;
using System.Reflection;
using Starfield.Utilities;

namespace Starfield.Core.Item {
    
    public class ItemBase {
        
        // TODO is it worth caching this?
        protected ItemAttribute Attribute {
            get {
                return GetType().GetCustomAttribute<ItemAttribute>(false);
            }
        }
        
        public Identifier Id { get { return Attribute.Id; } }
        public int ProtocolId { get { return Attribute.ProtocolId; } }

        public byte MaximumStackSize { get { return Attribute.MaximumStackSize; } }
        
        private static ItemAttribute GetAttribute(Type item) {
            return item.GetCustomAttribute<ItemAttribute>(false);
        }
        
        public static Identifier GetId(Type item) {
            return GetAttribute(item).Id;
        }
        
        public static int GetProtocolId(Type item) {
            return GetAttribute(item).ProtocolId;
        }

        public static byte GetMaximumStackSize(Type item) {
            return GetAttribute(item).MaximumStackSize;
        }
    }
    
    public class BlockItem : ItemBase {
        
        public int BlockProtocolId { get { return Attribute.BlockProtocolId; } }
    }

    public class FoodItem : ItemBase {
            
        public int Nutrition { get { return Attribute.Nutrition; } }
        public float SaturationModifier { get { return Attribute.SaturationModifier; } }
        public bool CanAlwaysEat { get { return Attribute.CanAlwaysEat; } }
    }

    /// <summary>
    /// also sword
    /// </summary>
    public class ToolItem : ItemBase {
            
        public int Uses { get { return Attribute.Uses; } }
        public float Speed { get { return Attribute.Speed; } }
            
        public float AttackDamage { get { return Attribute.AttackDamage; } }
        public float AttackDamageBonus { get { return Attribute.AttackDamageBonus; } }
    }

    public class PickaxeItem : ToolItem {
            
        /// <summary>
        /// list of block protocol ids that the pickaxe is able to break
        /// </summary>
        public int[] DiggableBlocks { get { return Attribute.DiggableBlocks; } }
    }
        
    public class ShovelItem : ToolItem {
            
        /// <summary>
        /// list of block protocol ids that the pickaxe is able to break
        /// </summary>
        public int[] DiggableBlocks { get { return Attribute.DiggableBlocks; } }
            
        public Dictionary<ushort, ushort> FlattenableBlockStates { get { return Attribute.FlattenableBlockStates; } }
    }
        
    public class AxeItem : ToolItem {
            
        /// <summary>
        /// list of block protocol ids that the pickaxe is able to break
        /// </summary>
        public int[] DiggableBlocks { get { return Attribute.DiggableBlocks; } }
        public string[] EffectiveMaterials { get { return Attribute.EffectiveMaterials; } }
            
        public Dictionary<ushort, ushort> StrippableBlocks { get { return Attribute.StrippableBlocks; } }
    }
        
    public class HoeItem : ToolItem {
            
        /// <summary>
        /// list of block protocol ids that the pickaxe is able to break
        /// </summary>
        public int[] DiggableBlocks { get { return Attribute.DiggableBlocks; } }
            
        public Dictionary<ushort, ushort> TillableBlockStates { get { return Attribute.TillableBlockStates; } }
    }
}