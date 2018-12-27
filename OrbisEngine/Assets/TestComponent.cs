using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using OrbisEngine.ItemSystem;

public class TestComponent : ItemComponent {

    public TestComponent(IItem source) : base(source) {}

    public override void InitialiseComponent()
    {
        messageHandlers.Add("test", (message) => {
            TestMessage testMessage = message as TestMessage;
            if (testMessage == null)
                return;
            if (testMessage.Message == "TEST") {
                m_baseItem.SendMessage("test", new TestMessage("derp"));
            }
        });
    }

}
