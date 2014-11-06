using UnityEngine;
using System.Collections;

public class Portal : MonoBehaviour {

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
			Application.LoadLevel ("Level1");
		}
	}
}
