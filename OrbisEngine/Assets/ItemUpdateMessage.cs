using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using OrbisEngine.ItemSystem;

public class ItemUpdateMessage : IMessage
{
    public string Message
    {
        get
        {
            throw new System.NotImplementedException();
        }

        set
        {
            throw new System.NotImplementedException();
        }
    }
    public string UpdateType;
    public ItemUpdateMessage(string updateType)
    {
        UpdateType = updateType;
    }

    public const string NewComponentAdded = "NEW_COMPONENT";
}
