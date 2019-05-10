using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bosskill2 : MonoBehaviour {

	public GameObject Card;
	public GameObject Explosion;
	public GameObject Pannel2;
	public GameObject Suicide;
	public GameObject Icon1;
	public AudioSource Boom;
	public AudioSource Alert;


	void OnTriggerEnter () 
	{
		Card.SetActive (false);
		Explosion.SetActive (true);
		Pannel2.SetActive (false);
		Suicide.SetActive (true);
		Icon1.SetActive (false);	
		Boom.Play();		
		Alert.Play();
	}
}