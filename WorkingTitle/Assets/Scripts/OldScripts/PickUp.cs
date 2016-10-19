using UnityEngine;
using System.Collections;

public class PickUp : MonoBehaviour
{       private Transform pickItUp;

        void Update()
    {

        if (Input.GetKeyDown(KeyCode.E))
        {

            transform.parent = pickItUp;

        }
        else if (Input.GetKeyDown(KeyCode.E))
        {

            transform.parent = null;

        }

    }

    void OnTriggerEnter(Collider col)
    {

        if (col.CompareTag("Player"))
        {

            pickItUp = col.transform;

        }

    }

    void OnTriggerExit(Collider col)
    {

        if (col.CompareTag("Player"))
        {
            pickItUp = null;
        }

    }
}
