using UnityEngine;
using System.Collections;
using UnityEngine.UI;
[RequireComponent(typeof(Text))]

public class Typer : MonoBehaviour {
	public string msg = Terminal.TerminalArt.initConsole();
	private Text textComp;
	public float startDelay = 1f;
	public float typeDelay = 0.004f;

	// Use this for initialization
	void Start () {
		StartCoroutine("TypeIn");
	}

	void Awake(){
		textComp = GetComponent<Text>();
	}


	public IEnumerator TypeIn(){
		yield return new WaitForSeconds(startDelay);

		for(int i = 0;i < msg.Length; i++){
			textComp.text = msg.Substring(0,i);
			//GetComponent<AudioSource>().PlayOneShot(putt);
			yield return new WaitForSeconds(typeDelay);
		}



	}
	
}
