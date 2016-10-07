using UnityEngine;
using System.Collections;

public class CameraAnim : MonoBehaviour {
    public Camera fpsCamera;
    public Camera animCamera;


	// Use this for initialization
	void Start () {
        fpsCamera.enabled = false;
        animCamera.enabled = true;

	}
	
	// Update is called once per frame
	void Update () {
        
	
	}
}
