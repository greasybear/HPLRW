using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TermTextShaddow : MonoBehaviour {
	public Text mirrorObj;
	public Text shaddow;

	

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		shaddow.text = mirrorObj.text;
	
	}
}
