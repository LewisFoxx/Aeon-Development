using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class maptest : MonoBehaviour
{

    public GameObject MAP;
	public GameObject Weapon;
	public GameObject Reticle;
	public GameObject Compass;
    public AudioSource MapTunes;
	
	void Start ()
	{
		Cursor.visible = false;
	}
	

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")//&& (Input.GetKeyDown("m")))
			MAP.SetActive (true);
		Cursor.lockState = CursorLockMode.None;
		Cursor.visible = true;
			Weapon.SetActive (false);
			Reticle.SetActive (false);
			Compass.SetActive (false);
			MapTunes.Play();
		StartCoroutine("MapOff");
    }

    IEnumerator MapOff()
    {
        yield return new WaitForSeconds(10);
        //CollectExplain.SetActive (true);
		MAP.SetActive(false);
		Weapon.SetActive (true);
		Reticle.SetActive (true);
		Compass.SetActive (true);
		MapTunes.Stop();
		Cursor.lockState = CursorLockMode.Locked;
		Cursor.visible = false;
    }
}