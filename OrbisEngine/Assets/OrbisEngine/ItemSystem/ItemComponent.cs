using System;
using System.Collections;
using System.Collections.Generic;
using OrbisEngine.ItemSystem;

[System.Serializable]
public class ItemComponent : IComponent
{
    protected Dictionary<string, Action<IMessage>> messageHandlers;

    protected IItem m_baseItem;
    public IItem Source {
        get {
            return m_baseItem;
        }
        set {
            m_baseItem = value;
        }
    }

    public ItemComponent(IItem baseItem)
    {
        m_baseItem = baseItem;
        messageHandlers = new Dictionary<string, Action<IMessage>>();
        InitialiseComponent();
    }

    public virtual void InitialiseComponent() { }

    public virtual void HandleMessage(string type, IMessage message)
    {
        if(messageHandlers.ContainsKey(type))
            messageHandlers[type](message);
    }
}
