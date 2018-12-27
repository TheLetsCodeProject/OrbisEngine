using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace OrbisEngine.ItemSystem
{
    public static class ItemExtensions
    {

        // I feel very smart about this one :)
        public static T GetComponent<T>(this IItem item) where T: class
        {
            for (int i = 0; i < item.Components.Count; i++)
            {
                T component = item.Components[i] as T;
                if (component != null)
                {
                    return component;
                }
            }
            return null;
        }
    }
}
