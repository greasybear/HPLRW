using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class SceneLoader : MonoBehaviour {
	
	 void FixedUpdate()

    {
        if (Input.GetKeyDown(KeyCode.Space))
            { SceneManager.LoadScene("GameplayTest1", LoadSceneMode.Single); }
            
    }
}
