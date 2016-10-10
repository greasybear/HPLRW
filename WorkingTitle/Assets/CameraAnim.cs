using UnityEngine;
using System.Collections;

public class CameraAnim : MonoBehaviour {
    public Camera fpsCamera;
    public Camera animCamera;
    public Camera ZoomCam;
    Animator DimensionChange;

    void Start () {
        fpsCamera.enabled = false;
        animCamera.enabled = true;
        ZoomCam.enabled = false;
        DimensionChange = GetComponent<Animator>();
        DimensionChange.SetBool("StartZoom", false);

	}
	
	void Update () {
        if (Input.GetKeyDown(KeyCode.E))
        {
            DimensionChange.SetBool("StartZoom", true);

            fpsCamera.enabled = false;
            animCamera.enabled = false;
            ZoomCam.enabled = true;

        }
        if (this.DimensionChange.GetCurrentAnimatorStateInfo(0).IsName("DimensionChange"))
            {
            fpsCamera.enabled = true;
            animCamera.enabled = false;
            ZoomCam.enabled = false;
            }
      
                        

    }
}
