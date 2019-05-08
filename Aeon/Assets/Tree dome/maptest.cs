using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class maptest : MonoBehaviour
{

    public GameObject MAP;
	public GameObject Weapon;
	public GameObject Reticle;
	public GameObject Compass;
    //public GameObject AttachedObject;


    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")//&& (Input.GetKeyDown("m")))
		Cursor.visible=true; 
        MAP.SetActive (true);
		Weapon.SetActive (false);
		Reticle.SetActive (false);
		Compass.SetActive (false);
		//Cursor.lockState = CursorLockMode.None;
		StartCoroutine("MapOff");
    }

    IEnumerator MapOff()
    {
        yield return new WaitForSeconds(10);
        //CollectExplain.SetActive (true);
		Weapon.SetActive (true);
		Reticle.SetActive (true);
		Compass.SetActive (true);
		Cursor.visible = false;
		//Cursor.lockState = CursorLockMode.Locked;
        MAP.SetActive(false);
    }
}