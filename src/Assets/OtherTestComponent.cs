using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using OrbisEngine.ItemSystem;

public class OtherTestComponent : ItemComponent {

    public override void HandleMessage(string type, IMessage message)
    {
        TestMessage testMessage = message as TestMessage;
        if (testMessage == null)
            return;

        if(testMessage.Message == "derp") {
            Debug.Log("Indirect Execution");
        }
    }
}
