using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SendDamage : MonoBehaviour {

	void OnCollisionStay(Collision other)
	{
		//We compare the tag in the other object to the tag we created earlier
		if(other.transform.CompareTag("Player"))
		{
			//If the above matches then send a message to the other object
			//this will also pass a value of 1 for our damage
			other.transform.SendMessage ("ApplyDamage", 1);
		}
	}
}
