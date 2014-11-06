using UnityEngine;
using System.Collections;

public class FadeAway : MonoBehaviour 
{

	void Start () 
	{
	
	}
	
	void Update () 
	{
	
	}

	public void fade()
	{
		StartCoroutine(fadeAwayRoutine());
		
	}

	IEnumerator fadeAwayRoutine()
	{
		yield return new WaitForSeconds(0);
	}
}
