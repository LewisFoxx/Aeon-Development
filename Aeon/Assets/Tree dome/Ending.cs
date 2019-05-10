using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Ending : MonoBehaviour {
	
	public GameObject Black;
	public GameObject Reticle;
	public GameObject Arms;
	public GameObject Compass;
	public AudioSource Music;
	


    void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Player")//&& (Input.GetKeyDown("m")))
			Black.SetActive (true);
			Reticle.SetActive (false);
			Arms.SetActive (false);
			Compass.SetActive(false);
			Music.Stop();
		StartCoroutine("SwitchScene");
	}
	
	
	IEnumerator SwitchScene()
    {
        yield return new WaitForSeconds(5);
		Cursor.lockState = CursorLockMode.None;
		Cursor.visible = true;
		SceneManager.LoadScene("Main Menu");
	}
}
