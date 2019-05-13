using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataCollect : MonoBehaviour {

	public int RotateSpeed;
	public GameObject Data;
	public GameObject Notification;
	
	void Update () {
		RotateSpeed = 2;
		transform.Rotate (0, RotateSpeed, 0, Space.World);
	}
	
	void OnTriggerEnter () {
		Data.SetActive (false);
		Notification.SetActive (true);
	StartCoroutine("Collected");
	}
	
	IEnumerator Collected()
	{
		yield return new WaitForSeconds(5);
		Notification.SetActive(false);
	}
	
	
}
