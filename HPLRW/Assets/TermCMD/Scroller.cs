using UnityEngine;
using System.Collections;
using UnityEngine.UI;  // Required when Using UI elements.

public class Scroller : MonoBehaviour
{
	public ScrollRect myScrollRect;
	public Scrollbar newScrollBar;
	
	public void Start () 
	{
		//Change the current vertical scroll position.
		myScrollRect.verticalNormalizedPosition = 0.5f;
	}
}