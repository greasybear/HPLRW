using UnityEngine;
using System.Collections;

public class MazeActivate : MonoBehaviour {
    
    public bool areYouClose;
    GameObject[] mazeWalls;
	void Start () {
        mazeWalls = GameObject.FindGameObjectsWithTag("ShadowWall");

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
    void Update () { if (areYouClose == true)
        {
            //mazeWalls.GetComponent<MeshRenderer>().enabled = !mazeWalls.GetComponent<MeshRenderer>().enabled;
            GetComponent<MeshRenderer>().enabled = true;
        }
            
                 
	
	}
}