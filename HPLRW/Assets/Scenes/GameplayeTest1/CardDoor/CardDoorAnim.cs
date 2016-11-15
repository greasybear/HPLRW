using UnityEngine;
using System.Collections;

public class CardDoorAnim : MonoBehaviour
{
    public bool gotCard;
    public bool areYouClose;
    Animator CardDoor;
    void Start()
    {
        gotCard = false;
        CardDoor = GetComponent<Animator>();
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

    void Update()
    {

        if (areYouClose == true && gotCard == true)
        {
            CardDoor.SetBool("Opening", true);
        }

        if (areYouClose == false)

            CardDoor.SetBool("Opening", false);

        

        
    }
}