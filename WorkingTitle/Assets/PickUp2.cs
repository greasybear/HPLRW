using UnityEngine;
using System.Collections;

public class PickUp2 : MonoBehaviour
{
    GameObject grabObject;
    float grabObjectSize;



    void Start ()
    {

    }

    GameObject GetMouseHoverObject(float range)
    {
        Vector3 position = gameObject.transform.position;
        RaycastHit raycasthit;
        Vector3 target = position + Camera.main.transform.forward * range;
        if (Physics.Linecast(position, target, out raycasthit))
            return raycasthit.collider.gameObject;
        return null;
    }
    bool canYouGrab(GameObject candidate)
    {
        return candidate.GetComponent<Rigidbody>() != null;

    }

    void GetAThing(GameObject pickUp)
    {
        if (pickUp == null || !canYouGrab(pickUp))
            return;

        grabObject = pickUp;
        grabObjectSize = pickUp.GetComponent<Renderer>().bounds.size.magnitude;

       
    }
    void DropObject()
    {
        if (grabObject == null)
            return;
        if (grabObject.GetComponent<Rigidbody>()!=null)
            grabObject.GetComponent<Rigidbody>().velocity = Vector3.zero;
        grabObject = null;
    }

    void Update ()
    { if (Input.GetKeyDown(KeyCode.E))
        {
            if (grabObject == null)
                GetAThing(GetMouseHoverObject(5));
            else
                DropObject();
        }
        if (grabObject != null)
        {
            Vector3 newPosition = gameObject.transform.position + Camera.main.transform.forward * grabObjectSize;
            grabObject.transform.position = newPosition;
        }
    }
        

   
}