using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Xml.Serialization;
using OrbisEngine.ItemSystem;
using System.IO;

public class TestSystem : MonoBehaviour {

    IItem item = new TestItem();
	// Use this for initialization
	void Start () {
        item.SendMessage("TEST", new TestMessage("TEST"));
        XmlSerializer XmlFormatter = new XmlSerializer(typeof(Item));
        using(TextWriter writer = new StreamWriter(Application.streamingAssetsPath + "/test.json")) {
            XmlFormatter.Serialize(writer, item);
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
