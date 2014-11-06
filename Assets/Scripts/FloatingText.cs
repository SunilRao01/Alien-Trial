using UnityEngine;
using System.Collections;

public class FloatingText : MonoBehaviour 
{
	public float letterDelay;

	private bool isAnimating;
	private string currentString;
	private int currentPosition;
	private string originalText;

	void Start () 
	{
		currentString = "";
		originalText = GetComponent<TextMesh>().text;
		currentPosition = 0;
	}
	
	void Update () 
	{
		GetComponent<TextMesh>().text = currentString;
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.name == "Player")
		{
			if (!isAnimating)
			{
				StartCoroutine(animateText());
			}
		}
		
	}

	IEnumerator animateText()
	{
		isAnimating = true;

		while (currentPosition < originalText.Length)
		{
			yield return new WaitForSeconds(letterDelay);
			currentString += originalText[currentPosition];
			audio.Play();
			currentPosition++;
		}
	}
}
