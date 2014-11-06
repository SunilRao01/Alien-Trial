using UnityEngine;
using System.Collections;

public class SpeedBoost : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.name == "Player")
		{
			Debug.Log("Boost player");
				// TODO: Boost other.getcomponent<player>'s speed function
		}
	}
}
