﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class MoveToPosition : MonoBehaviour {

	public float knockbackTime = 1;
	public float kick = 1.8f;
	public Transform goal;
	private NavMeshAgent agent;
	private bool hit;
	private ContactPoint contact;
	private float timer;

	// Use this for initialization
	void Start () {

		goal = GameObject.FindGameObjectWithTag ("Player").transform;
		agent = GetComponent<NavMeshAgent> ();

		//Set timer to the same as knockback in first instance
		timer = knockbackTime;

	}
	
	// Update is called once per frame
	void Update () {

		if (hit) {
			//Allow physics to be applied
			gameObject.GetComponent<Rigidbody> ().isKinematic = false;
			//Stop our AI navigation
			gameObject.GetComponent<NavMeshAgent> ().isStopped = true;
			//Push back our enemy with an impulse force set via our kick value
			gameObject.GetComponent<Rigidbody> ().AddForceAtPosition (Camera.main.transform.forward * kick, contact.point, ForceMode.Impulse);

			hit = false;
			timer = 0;
		}
		else{
			timer += Time.deltaTime;
			//After being knocked back, retsrat movement after x seconds
			if (knockbackTime < timer) {
				gameObject.GetComponent<Rigidbody> ().isKinematic = true;
				gameObject.GetComponent<NavMeshAgent> ().isStopped = false;
				agent.SetDestination (goal.position);
			}
	}
}

	void OnCollisionEnter (Collision other)
	{
		//We compare the tag in the other object to the tag name we set earlier
		if (other.transform.CompareTag ("bullet")) {
			contact = other.contacts [0];
			hit = true;
		}
	}
}
