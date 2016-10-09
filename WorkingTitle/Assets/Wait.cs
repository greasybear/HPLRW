using UnityEngine;
using System.Collections;

public class Wait : MonoBehaviour
{
    public GameObject objectToActivate;

    private void Start()
    {
        StartCoroutine(ActivationRoutine());
    }

    private IEnumerator ActivationRoutine()
    {
        //Wait for 10 secs.
        yield return new WaitForSeconds(10);
        

        //Turn My game object that is set to false(off) to True(on).
        objectToActivate.SetActive(true);

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Destroy(objectToActivate);
        }

    }
   }