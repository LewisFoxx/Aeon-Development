using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GearUp : MonoBehaviour {

	public GameObject Case;
	public GameObject Weapon;
	public GameObject Reticle;
	public GameObject Compass;
	// GameObject HUD;
	public AudioSource ReadyUp;
	
	void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")//&& (Input.GetKeyDown("m")))
			Case.SetActive (false);
			Weapon.SetActive (true);
			Reticle.SetActive (true);
			Compass.SetActive (true);
			//HUD.SetActive (true);
			ReadyUp.Play();
	}
}