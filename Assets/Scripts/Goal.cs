using UnityEngine;
using System.Collections;

public class Goal : MonoBehaviour 
{
	public float rotationSpeed;

	public bool xRotation;
	public bool yRotation;
	public bool zRotation;

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (yRotation)
		{
			transform.Rotate(Vector3.right * rotationSpeed);
		}
		else if (xRotation)
		{
			transform.Rotate(Vector3.up * rotationSpeed);
		}
		else if (zRotation)
		{
			transform.Rotate(Vector3.forward * rotationSpeed);
		}

	}

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.name == "Player")
		{
			Application.LoadLevel ("EndMenu");
		}
	}
}
