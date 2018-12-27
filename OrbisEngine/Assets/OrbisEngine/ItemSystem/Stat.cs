using System;
using System.Collections.Generic;
using UnityEngine;

namespace OrbisEngine.ItemSystem
{

    // A stat class based on the tutorial found here: https://www.youtube.com/watch?v=SH25f3cXBVc
    public class Stat
    {
        public float BaseValue;
        public float Value {
            get {
                if (isDirty) {
                    _value = CalculateFinalValue();
                    isDirty = false;
                }
                return _value;
            }
        }

        private readonly List<StatModifier> statModifiers;
        private bool isDirty = true;
        private float _value;

        public Stat(float baseValue)
        {
            BaseValue = baseValue;
            statModifiers = new List<StatModifier>();
        }

        public void AddModifier(StatModifier mod)
        {
            isDirty = true;
            statModifiers.Add(mod);
            statModifiers.Sort(CompareModifierOrder);
        }

        public bool RemoveModifier(StatModifier mod)
        {
            isDirty = true;
            return statModifiers.Remove(mod);
        }

        public void RemoveModifiersFromSource(object source)
        {
            for (int i = statModifiers.Count; i >= 0; i--) {
                StatModifier mod = statModifiers[i];
                if(mod.Source == source) {
                    statModifiers.Remove(mod);
                }
            }
        }

        // This is a simple comparative function to sort our modifiers based on precedence
        private int CompareModifierOrder(StatModifier a, StatModifier b)
        {
            if(a.Order < b.Order) {
                return -1;
            } else if(a.Order > b.Order) {
                return 1;
            }
            return 0;
        }

        private float CalculateFinalValue()
        {
            float finalValue = BaseValue;
            float percentAdditive = 0f;

            for (int i = 0; i < statModifiers.Count; i++) {
                StatModifier mod = statModifiers[i];

                if(mod.Type == ModifierType.Flat) {
                    finalValue += mod.Value;
                }
                else if(mod.Type == ModifierType.PercentAdditive) {
                    percentAdditive += mod.Value;
                }
                else if(mod.Type == ModifierType.PercentDiscrete) {
                    // This ensures that we are indeed increasing by percent
                    // Eg; A 10% increase is 110% of the original value: 1 + 0.10
                    finalValue *= 1 + mod.Value;
                }
            }
            finalValue *= 1 + percentAdditive;
            return (float)Math.Round(finalValue, 4); //Fixes floating point errors
        }

    }
}
