using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour {

//Private means only this script can access the variable
	private int hitNumber;

	private void OnEnable()
	{
		hitNumber = 0;
	}

	//Unity stores the collider it hits and we can access it via the name other
	void OnCollisionEnter(Collision other){
		//We compare the tag in the other object to the tag name we set earlier
		if (other.transform.CompareTag ("bullet")) {
			//If the comparison is true, we can increase the hit number
			hitNumber++;
		}

		//if the hit number is equal to 3 we destory this object
		if (hitNumber == 3) {
			gameObject.SetActive (false);
		}
		
	}
}
