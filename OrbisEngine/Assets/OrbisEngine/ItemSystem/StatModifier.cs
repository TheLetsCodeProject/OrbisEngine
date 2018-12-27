using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace OrbisEngine.ItemSystem
{
    // This is a data object and should therefore be treated as one. No functionalilty should be added 
    // to this class unless it is to assist with assigning data.
    public class StatModifier
    {
        public readonly float Value;
        public ModifierType Type;
        public int Order;
        public object Source;

        public StatModifier(float value, ModifierType type, int order, object source)
        {
            Value = value;
            Type = type;
            Order = order;
            Source = source;
        }

        public StatModifier(float value, ModifierType type) : this(value, type, (int)type, null) { }
        public StatModifier(float value, ModifierType type, int order) : this(value, type, order, null) { }
        public StatModifier(float value, ModifierType type, object source) : this(value, type, (int)type, source) { }
    }


    /// <summary>
    /// The method by which the modifier is used to calculate. Flat: add this mod
    /// as a flat rate. Discrete: increase as a percent individual from other
    /// percentages. Additive: this stat and all other additive stats will
    /// have their boost culminated before being added.
    /// </summary>
    public enum ModifierType {
        Flat = 100,
        PercentDiscrete = 200,
        PercentAdditive = 300
    }
}
