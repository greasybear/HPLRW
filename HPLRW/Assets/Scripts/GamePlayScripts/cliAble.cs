using UnityEngine;
using System.Collections;

public class cliAble : MonoBehaviour {

	// Use this for initialization
	void Start () {
		GameObject fps = GameObject.Find("FPSController");
		Inventory inventory = fps.GetComponent <Inventory>();
		inventory.cliObjects.Add(this.name.ToString());
		
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
