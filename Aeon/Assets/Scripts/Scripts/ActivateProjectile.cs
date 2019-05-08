using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateProjectile : MonoBehaviour {

	public GameObject projectile;
	public AudioSource playerShot;

	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			playerShot.Play ();
			var clone = Instantiate (projectile, gameObject.transform.position, gameObject.transform.rotation);
			//Destroy after 2 seconds to stop clutter
			Destroy (clone, 5.0f);
		}
	}
}
