using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateProjectile : MonoBehaviour {

	public GameObject projectile;
	
public float fireRate = 1.0f;
	private float lastShot= 0.0f;
	public AudioSource playerShot;

	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			
			if (Time.time > fireRate + lastShot)
			{
				playerShot.Play ();
				var clone = Instantiate (projectile, gameObject.transform.position, gameObject.transform.rotation);
				lastShot = Time.time;
				//Destroy after 2 seconds to stop clutter
				Destroy (clone, 5.0f);
			}
		}
	}
}
