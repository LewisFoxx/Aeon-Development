using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Press the space key in Play Mode to switch to the Bounce state.

public class Animations : MonoBehaviour
{
	public GameObject Shoot;
	
    Animator anim;

    void Start()
    {
        anim = GetComponent<Animator> ();
		//Shoot.SetActive (true);
    }

    void Update() {
        RunDup();
        //IdleWlk():

    }

    void RunDup()
    {
        anim.SetBool("Run", Input.GetButton("Fire3"));
		//Shoot.SetActive (false);
    }  
}