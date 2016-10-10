using UnityEngine;
using System.Collections;
using System.Collections.Generic; 
using UnityEngine.UI;

public class TermInput : MonoBehaviour {
	InputField input; 
	InputField.SubmitEvent se; 
	public Text output;
	Terminal.VirtualFileSystem vfs = new Terminal.VirtualFileSystem(); 

	// Use this for initialization
	void Start () {
		input = gameObject.GetComponent<InputField>();
		se = new InputField.SubmitEvent();
		output.text = Terminal.TerminalArt.initConsole(); 
		//Listener Callback 	
		se.AddListener(SubmitInput);
		input.onEndEdit = se;
	}

	private void SubmitInput(string arg0){
		
		string currentText = output.text;
		string newText = (arg0.Equals("clear")) ? "" 
			: currentText+ "\n" + Terminal.Parser.termParse(arg0);
		output.text = newText;
		input.text = "> ";
		input.ActivateInputField(); 
	}
		
}
