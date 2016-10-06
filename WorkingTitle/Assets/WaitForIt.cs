using UnityEngine;
using System.Collections;

public class WaitForIt : MonoBehaviour
{


    void Start()
    {
        gameObject.SetActive(false);
        StartCoroutine(informPlayer());
    }
    IEnumerator informPlayer()
    {
        yield return new WaitForSeconds(20f);
        gameObject.SetActive(true);
    }

}
