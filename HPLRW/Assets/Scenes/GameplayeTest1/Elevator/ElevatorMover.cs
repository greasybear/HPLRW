using UnityEngine;
using System.Collections;

public class ElevatorMover : MonoBehaviour {

    Animator Elevator;
    Animator anim;
    private bool inElevator;
    public GameObject rider;
    public GameObject theBox;

    void Start()
    {
        anim = GetComponent<Animator>();
    }
    void OnTriggerEnter(Collider hit)
    {
        if (hit.transform.tag == "Player")
            inElevator = true;
        rider.transform.parent = theBox.transform;
    }
    void OnTriggerExit(Collider hit)
    {
        if (hit.transform.tag == "Player")
            inElevator = false;
        rider.transform.parent = null;
    }




        void Update()
    {

        if (Input.GetKeyDown(KeyCode.E) && inElevator == true)
        {
            anim.SetBool("GoingDown", true);
            
            

        }
        if (Input.GetKeyUp(KeyCode.E) || inElevator == false)

        {
            anim.SetBool("GoingDown", false);

        }
        if (Input.GetKeyDown(KeyCode.E) && inElevator == true)
        {
            anim.SetBool("GoingUp", true);
            
        }
        if (Input.GetKeyUp(KeyCode.E) || inElevator == false)

        {
            anim.SetBool("GoingUp", false);

        }

    }
}
