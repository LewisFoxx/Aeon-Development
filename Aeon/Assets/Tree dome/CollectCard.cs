using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectCard : MonoBehaviour {

	public int RotateSpeed;
	public AudioSource CollectSound;
	public GameObject Card;
	

	void Update () {
		RotateSpeed = 2;
		transform.Rotate (0, RotateSpeed, 0, Space.World);
	}


	void OnTriggerEnter () {
		CollectSound.Play ();
		Card.SetActive (false);
	}
}