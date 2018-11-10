using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using OrbisEngine.ItemSystem;

public class TestComponent : ItemComponent {

    public TestComponent(IItem source)
    {
        m_Source = source;
    }

    public override void HandleMessage(string type, IMessage message)
    {
        TestMessage testMessage = message as TestMessage;
        if (testMessage == null)
            return;
        if(testMessage.Message == "TEST") {
            Source.SendMessage("TEST", new TestMessage("derp"));
        }
    }

}
