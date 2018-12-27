using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using OrbisEngine.ItemSystem;

public class TestMessage : IMessage
{
    private string m_Message;
    public string Message {
        get {
            return m_Message;
        }

        set {
            m_Message = value;
        }
    }

    public TestMessage(string message)
    {
        m_Message = message;
    }
}
