using UnityEngine;
using System.Collections;

public class Instructions : MonoBehaviour
{
    public string text;
    
    void OnGUI()
    {  if (Input.GetKeyDown(KeyCode.Space))
        
        {
            GUI.Box(new Rect(10, 10, 10, 20), text);
        }
    }

}
