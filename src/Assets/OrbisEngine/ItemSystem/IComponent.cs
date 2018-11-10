using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace OrbisEngine.ItemSystem
{
    public interface IComponent
    {
        IItem Source { get; set; }   
        void HandleMessage(string type, IMessage message);
    }
}
