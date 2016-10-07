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
        //Wait for 15 secs.
        yield return new WaitForSeconds(15);

        //Turn My game object that is set to false(off) to True(on).
        objectToActivate.SetActive(true);

    }
    

}