using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class StartDelay : MonoBehaviour 
{
	public List<GUIText> texts;
	public float introDelay;

	// Use this for initialization
	void Start () 
	{
		for (int i = 0; i < texts.Count; i++)
		{
			Color newColor = texts[i].color;
			newColor.a = 0;
			texts[i].color = newColor;
		}

		StartCoroutine(introDelayRoutine());
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}

	IEnumerator introDelayRoutine()
	{
		yield return new WaitForSeconds(introDelay);

		for (int i = 0; i < texts.Count; i++)
		{
			Color newColor = texts[i].color;
			newColor.a = 1;
			texts[i].color = newColor;
		}
	}
		
}
