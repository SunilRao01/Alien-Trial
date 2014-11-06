// by @torahhorse

using UnityEngine;
using System.Collections;

public class LockMouse : MonoBehaviour
{	
	void Start()
	{
		LockCursor(true);
		Screen.showCursor = false;
	}

    void Update()
    {
    	// lock when mouse is clicked
    	if( Input.GetMouseButtonDown(0) && Time.timeScale > 0.0f )
    	{
    		LockCursor(true);
			Screen.showCursor = false;
    	}
    
    	// unlock when escape is hit
        if  ( Input.GetKeyDown(KeyCode.Escape) )
        {
        	LockCursor(!Screen.lockCursor);
        }
    }
    
    public void LockCursor(bool lockCursor)
    {
    	Screen.lockCursor = lockCursor;
    }
}