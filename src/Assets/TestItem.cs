using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using OrbisEngine.ItemSystem;

public class TestItem : Item {

    public TestItem()
    {
        m_Components = new List<IComponent>() {
            new TestComponent(this),
            new OtherTestComponent()
        };
    }

}
