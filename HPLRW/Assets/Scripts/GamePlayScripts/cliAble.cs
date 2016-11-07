using UnityEngine;
using System.Collections;

public class cliAble : MonoBehaviour {
	// Use this for initialization
	void Awake () { //change from start function
        GameObject fps = GameObject.FindWithTag("Player");
        Inventory inventory = fps.GetComponent<Inventory>();
        inventory.cliObjects.Add(this.gameObject);

        Debug.Log("Added an item to inventory");
        inventory.cliObjects.ForEach(x => Debug.Log(x));


    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
