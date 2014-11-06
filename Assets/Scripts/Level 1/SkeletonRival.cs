using UnityEngine;
using System.Collections;

public class SkeletonRival : MonoBehaviour 
{
	public float pathSpeed;

	// Use this for initialization
	void Start () 
	{
		animation.Play("run");
		iTween.MoveTo(gameObject, iTween.Hash("path", iTweenPath.GetPath("rival_path"), "speed", pathSpeed, 
		                                      "easetype", iTween.EaseType.linear, "orienttopath", true, "movetopath", false));
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}
}
