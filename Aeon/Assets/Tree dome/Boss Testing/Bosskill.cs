using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bosskill : MonoBehaviour {

	public GameObject Card;
	public GameObject Explosion;
	public GameObject Pannel2;


	void OnTriggerEnter () 
	{
		Card.SetActive (false);
		Explosion.SetActive (true);
		Pannel2.SetActive (true);
		
	}
}