using UnityEngine;
using System.Collections;

public class Distance : MonoBehaviour
{
    private Animator animator;

    public bool inRange;


    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")

        { inRange = true; }


    }



    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")

        { inRange = false; }
    }


}