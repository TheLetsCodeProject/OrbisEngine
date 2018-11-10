using System;
using System.Collections.Generic;
using UnityEngine;

namespace OrbisEngine.ItemSystem
{
    [System.Serializable]
    public abstract class Item : IItem
    {
        public string Name = "Unamed Item";

        public List<IComponent> m_Components;
        public List<IComponent> Components {
            get {
                return m_Components;
            }
        }

        public void AddComponent(IComponent component)
        {
            m_Components.Add(component);
        }

        public void RemoveComponent(IComponent component)
        {
            m_Components.Remove(component);
        }

        public void SendMessage(string type, IMessage message)
        {
            for (int i = 0; i < m_Components.Count; i++) {
                m_Components[i].HandleMessage(type, message);
            }
        }
    }
}
