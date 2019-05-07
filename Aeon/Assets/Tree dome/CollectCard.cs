using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectCard : MonoBehaviour {

	public int RotateSpeed;
	public AudioSource Trigger;
	public GameObject Card;


    void Update () {
		RotateSpeed = 2;
		transform.Rotate (0, RotateSpeed, 0, Space.World);
	}


	void OnTriggerEnter () {
		Trigger.Play ();
		Card.SetActive (false);
	}
}