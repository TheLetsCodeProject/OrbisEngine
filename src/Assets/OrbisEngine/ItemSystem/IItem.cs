using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace OrbisEngine.ItemSystem
{
    public interface IItem
    {

        List<IComponent> Components { get; }

        void SendMessage(string type, IMessage message);

        void AddComponent(IComponent component);
        void RemoveComponent(IComponent component);

    }

}
