using UnityEngine;
using System.Collections;

public class Bounce : MonoBehaviour 
{
	public float bounceDistance;
	public float bounceSpeed;

	void Start () 
	{
	
	}
	
	void Update () 
	{
		// Set the y position to loop much faster between -3 and 3
		Vector3 newPosition = transform.position;
		newPosition.y = Mathf.Sin(Time.time * bounceSpeed) * bounceDistance;
		transform.position = newPosition;
	}
}
