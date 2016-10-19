using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ReadingNotes : MonoBehaviour

{


    public GameObject noteReader;

    public bool areYouReading;

    private bool areYouClose;


    void Start()
    {
        areYouReading = false;

    }
    void OnTriggerEnter(Collider hit)
    {
        if (hit.transform.tag == "Player")
            areYouClose = true;
     }
    void OnTriggerExit(Collider hit)
    { if (hit.transform.tag == "Player")
            areYouClose = false;
                }



    void Update()
    {
        if (areYouReading)
        {
            readerRabbit(true);
        }
        else {
            readerRabbit(false);
        }
        if (Input.GetKeyDown(KeyCode.G) && areYouClose == true)
        {
            turnOnReader();
        }

    }
    void readerRabbit(bool state)
    {
        if (state)
        {
            Time.timeScale = 0.0f; //reading a note
        }
        else {
            Time.timeScale = 1.0f; //exiting reader
            noteReader.SetActive(state);
        }
        noteReader.SetActive(state);
    }
    public void turnOnReader()
    {
        if (areYouReading)
        {
            areYouReading = false; //Changes the value
        }
        else
        {
            areYouReading = true;
        }
    }
}
