﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bosskill : MonoBehaviour {

	public GameObject Card;
	public GameObject Explosion;
	public GameObject Pannel2;
	public GameObject Icon1;
	public GameObject Icon2;
	public AudioSource Boom;


	void OnTriggerEnter () 
	{
		Card.SetActive (false);
		Explosion.SetActive (true);
		Pannel2.SetActive (true);
		Icon1.SetActive (false);
		Icon2.SetActive (true);
		Boom.Play();
		
	}
}