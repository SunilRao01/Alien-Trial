using UnityEngine;
using System.Collections;

public class SkeletonEnemy : MonoBehaviour 
{
	public bool isRunning;
	private GameObject playerObject;
	public float moveForce;
	public float maxSpeed;

	void Start () 
	{
		playerObject = GameObject.Find("Player");

	}
	
	void Update () 
	{
		if (isRunning)
		{
			followPlayer();
		}

		if (transform.GetChild(1).gameObject.renderer.isVisible)
		{
			Debug.Log("Skeleton in view");
		}
	}

	void followPlayer()
	{
		// Look at player
		transform.LookAt(playerObject.transform.position);
		Vector3 newRotation = transform.eulerAngles;
		newRotation.x = 0;
		transform.eulerAngles = newRotation;

		// Move towards player
		if (rigidbody.velocity.magnitude < maxSpeed)
		{
			rigidbody.AddRelativeForce(Vector3.forward * moveForce, ForceMode.Force);
		}
		isRunning = true;
	}

	void OnCollisionEnter(Collision other)
	{
		if (other.gameObject.name == "Player")
		{
			Application.LoadLevel(Application.loadedLevelName);
		}
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.name == "Player")
		{
			animation.Play("run");
			isRunning = true;
		}
	}
}
