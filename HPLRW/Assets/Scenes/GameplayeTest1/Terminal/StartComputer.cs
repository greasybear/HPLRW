using UnityEngine;
using System.Collections;

public class StartComputer : MonoBehaviour {
    public GameObject objectToEnable;
    public GameObject objectToDisable;
    public bool onOff;
    public bool areYouClose;
    public GameObject instructionText;

	
	void Start () {
        onOff = false;
        areYouClose = false;
        instructionText = GameObject.Find("Terminaltable");

    }

    void OnTriggerEnter(Collider hit)
    {
        if (hit.transform.tag == "Player")
            areYouClose = true;
    }
    void OnTriggerExit(Collider hit)
    {
        if (hit.transform.tag == "Player")
            areYouClose = false;
    }

    void Update () {
        if (Input.GetButtonDown("Cancel") && areYouClose==true)
            computerOn();
        if (onOff == true)
        {
            objectToDisable.SetActive(false);
            objectToEnable.SetActive(true);
            Cursor.visible = true;
            
        }
        else
        {
            objectToDisable.SetActive(true);
            objectToEnable.SetActive(false);
            Cursor.visible = false;
        }
	}
    public void computerOn()
    { if (onOff)
        { onOff = false; }
        else { onOff = true; }
        instructionText.GetComponent<Instructions>().enabled = !instructionText.GetComponent<Instructions>().enabled;
    }
    


}
