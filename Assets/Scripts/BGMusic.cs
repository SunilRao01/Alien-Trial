using UnityEngine;
using System.Collections;

public class BGMusic : MonoBehaviour 
{
	public string endMusicAtLevel;

	// Use this for initialization
	void Start () 
	{
		if (Application.loadedLevelName == endMusicAtLevel)
		{
			Destroy(gameObject);
		}
		else
		{
			DontDestroyOnLoad(gameObject);
		}
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}
}
