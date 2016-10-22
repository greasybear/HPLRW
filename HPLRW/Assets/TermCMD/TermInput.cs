using UnityEngine;
using System.Collections;
using System.Collections.Generic; 
using System.Linq;
using UnityEngine.UI;

public class TermInput : MonoBehaviour {
	InputField input; 
	InputField.SubmitEvent se; 
	public Text output;
	//Terminal.VirtualFileSystem vfs = new Terminal.VirtualFileSystem(); 
	public float typeDelay = 0.004f;

	// Use this for initialization
	void Start () {
		input = gameObject.GetComponent<InputField>();
		se = new InputField.SubmitEvent();
		//output.text = Terminal.TerminalArt.initConsole(); 
		//Listener Callback 	
		se.AddListener(runSubmit);
		input.onEndEdit = se;
	}

	public IEnumerator  SubmitInput(string arg0){
		string termOutput = Terminal.Parser.termParse(arg0); 
		string currentText = output.text;
		
		if(Terminal.delayPrint.cmds.Any(arg0.Contains)){
			for(int i = 0;i < termOutput.Length; i++){
				output.text = termOutput.Substring(0,i);
			//GetComponent<AudioSource>().PlayOneShot(putt);
				yield return new WaitForSeconds(typeDelay);
			}
         	input.text = "> ";
			input.ActivateInputField();
		
		} else {
			string newText = (arg0.Equals("clear")) ? "" 
				: currentText+ "\n" + termOutput;
			output.text = newText;
			input.text = "> ";
			input.ActivateInputField();
			Debug.Log(output.text);
			yield return null;
		}
	
	}
	private void runSubmit(string arg0){
		StartCoroutine(SubmitInput(arg0));
   }
}
