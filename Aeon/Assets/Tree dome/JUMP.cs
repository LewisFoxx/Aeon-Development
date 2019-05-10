using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JUMP : MonoBehaviour {

	public GameObject Jump;
	
	
	void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")//&& (Input.GetKeyDown("m")))
			Jump.SetActive (true);
		StartCoroutine("JumpNow");
	}
	
	
	IEnumerator JumpNow()
    {
        yield return new WaitForSeconds(2);
		Jump.SetActive(false);
	}
}
