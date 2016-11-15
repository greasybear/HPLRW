using UnityEngine;
using System.Collections;

public class KeyCard : MonoBehaviour {
    public bool areYouClose;

    

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
        if (Input.GetKeyDown(KeyCode.E) && areYouClose == true)
        {
            GameObject door = GameObject.Find("CardDoor");
            CardDoorAnim cardy = door.GetComponent<CardDoorAnim>();
            cardy.gotCard = true;
            
            gameObject.SetActive(false);
       
        }


    }
}
