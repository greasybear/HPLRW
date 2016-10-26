using UnityEngine;
using System.Collections;

public class StartComputer : MonoBehaviour {
    public GameObject objectToEnable;
    public GameObject objectToDisable;
    public bool onOff;
    public bool areYouClose;

	
	void Start () {
        onOff = false;
        areYouClose = false;
	
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
        { objectToDisable.SetActive(false);
            objectToEnable.SetActive(true);}
        else
        { objectToDisable.SetActive(true);
            objectToEnable.SetActive(false);}
	}
    public void computerOn()
    { if (onOff)
        { onOff = false; }
        else { onOff = true; }
    }
    


}
