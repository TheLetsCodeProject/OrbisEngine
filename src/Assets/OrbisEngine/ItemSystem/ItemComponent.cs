using System.Collections;
using System.Collections.Generic;
using OrbisEngine.ItemSystem;

[System.Serializable]
public class ItemComponent : IComponent
{

    protected IItem m_Source;
    public IItem Source {
        get {
            return m_Source;
        }
        set {
            m_Source = value;
        }
    }

    public virtual void HandleMessage(string type, IMessage message)
    {
        throw new System.NotImplementedException();
    }
}
