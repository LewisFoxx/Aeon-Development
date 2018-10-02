using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectHeart : MonoBehaviour {

	public int RotateSpeed;
	public AudioSource CollectSound;
	public GameObject Heart;
	

	void Update () {
		RotateSpeed = 2;
		transform.Rotate (0, RotateSpeed, 0, Space.World);
	}


	void OnTriggerEnter () {
		CollectSound.Play ();
		Heart.SetActive (false);
}
}