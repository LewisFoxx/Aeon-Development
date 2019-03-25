using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class recoil : MonoBehaviour {

	Animator anim;

	void Start ()
	{
		anim = gameObject.GetComponent<Animator> ();
	}

	void Update ()
	{
		if (Input.GetButton ("Fire1")) {
			anim.SetTrigger ("Active");
		}
	}
}
