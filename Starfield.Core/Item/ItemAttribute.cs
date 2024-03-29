using System;
using System.Collections.Generic;
using Starfield.Utilities;

namespace Starfield.Core.Item {
    
    // TODO strippable and tillable were supposed to be dictionaries but you cannot have dictionaries in attributes
    public class ItemAttribute : Attribute {
        
        public Identifier Id { get; }
        public int ProtocolId { get; }
        
        public byte MaximumStackSize { get; }
        public ItemType Type { get; }

        #region block item
        public int BlockProtocolId { get; }
        #endregion

        #region food itme
        public int Nutrition { get; }
        public float SaturationModifier { get; }
        public bool CanAlwaysEat { get; }
        #endregion

        #region tool (sword) item
        public int Uses { get; }
        public float Speed { get; }
        
        public float AttackDamage { get; }
        public float AttackDamageBonus { get; }
        #endregion

        #region pickaxe item
        public int[] DiggableBlocks { get; }
        #endregion

        #region shovel item
        public Dictionary<ushort, ushort> FlattenableBlockStates { get; }
        #endregion

        #region axe item
        public string[] EffectiveMaterials { get; }
            
        public Dictionary<ushort, ushort> StrippableBlocks { get; }
        #endregion

        #region hoe item
        public Dictionary<ushort, ushort> TillableBlockStates { get; }
        #endregion

        public ItemAttribute(string id, int protocolId, byte maximumStackSize) {
            Id = new Identifier(id);
            ProtocolId = protocolId;
            MaximumStackSize = maximumStackSize;
        }

        /// <summary>
        /// block item
        /// </summary>
        public ItemAttribute(string id, int protocolId, byte maximumStackSize,
            int blockProtocolId) : this(id, protocolId, maximumStackSize) {

            Type = ItemType.Block;
            
            BlockProtocolId = blockProtocolId;
        }

        /// <summary>
        /// food item
        /// </summary>
        public ItemAttribute(string id, int protocolId, byte maximumStackSize,
            int nutrition, float saturationModifier, bool canAlwaysEat)
            : this(id, protocolId, maximumStackSize) {

            Type = ItemType.Food;
            
            Nutrition = nutrition;
            SaturationModifier = saturationModifier;
            CanAlwaysEat = canAlwaysEat;
        }
        
        /// <summary>
        /// sword item
        /// </summary>
        public ItemAttribute(string id, int protocolId, byte maximumStackSize,
            int uses, float speed, float attackDamage, float attackDamageBonus)
            : this(id, protocolId, maximumStackSize) {

            Type = ItemType.Sword;
            
            Uses = uses;
            Speed = speed;
            AttackDamage = attackDamage;
            AttackDamageBonus = attackDamageBonus;
        }
        
        /// <summary>
        /// pickaxe item
        /// </summary>
        public ItemAttribute(string id, int protocolId, byte maximumStackSize,
            int uses, float speed, float attackDamage, float attackDamageBonus,
            int[] diggableBlocks)
            : this(id, protocolId, maximumStackSize, uses, speed, attackDamage, attackDamageBonus) {

            Type = ItemType.Pickaxe;
            
            DiggableBlocks = diggableBlocks;
        }
        
        /// <summary>
        /// hoe/shovel item
        /// </summary>
        public ItemAttribute(string id, int protocolId, byte maximumStackSize,
            int uses, float speed, float attackDamage, float attackDamageBonus,
            int[] diggableBlocks, bool isHoe)
            : this(id, protocolId, maximumStackSize, uses, speed, attackDamage, attackDamageBonus) {

            DiggableBlocks = diggableBlocks;
            
            if(isHoe) {
                Type = ItemType.Hoe;
                TillableBlockStates = null;
            } else {
                Type = ItemType.Shovel;
                FlattenableBlockStates = null;
            }
        }
        
        /// <summary>
        /// axe item
        /// </summary>
        public ItemAttribute(string id, int protocolId, byte maximumStackSize,
            int uses, float speed, float attackDamage, float attackDamageBonus,
            int[] diggableBlocks, string[] effectiveMaterials)
            : this(id, protocolId, maximumStackSize, uses, speed, attackDamage, attackDamageBonus) {

            Type = ItemType.Axe;
            
            DiggableBlocks = diggableBlocks;
            EffectiveMaterials = effectiveMaterials;
            StrippableBlocks = null;
        }
    }
}