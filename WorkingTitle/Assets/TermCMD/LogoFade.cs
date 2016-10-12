using UnityEngine;
using System.Collections;
using UnityEngine.UI;
[RequireComponent(typeof(Image))]

public class LogoFade: MonoBehaviour {
	public string msg = Terminal.TerminalArt.initConsole();
	private Image img;
	public float startDelay = 7.0f;

	// Use this for initialization
	void Start () {
		
		img.CrossFadeAlpha(0.0f, .004f, false);
		StartCoroutine("FadeIn");
		Debug.Log(img.color);
	}

	void Awake(){
		img = GetComponent<Image>();
	}

	public IEnumerator FadeIn(){
		yield return new WaitForSeconds(startDelay);
		img.CrossFadeAlpha(1.0f, 5.0f, false);
	}
	
}