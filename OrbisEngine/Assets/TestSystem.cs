using UnityEngine;
using OrbisEngine.ItemSystem;

public class TestSystem : MonoBehaviour {

    IItem item = new TestItem();
	// Use this for initialization
	void Start () {
        item.SendMessage("test", new TestMessage("TEST"));
        item.SendMessage(StatMessage.UpdateStat, new StatMessage("Health", new StatModifier(100, ModifierType.Flat)));
        Debug.Log(item.GetComponent<ItemStats>()["Health"]);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
