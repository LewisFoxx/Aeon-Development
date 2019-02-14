using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TeleportToMap : MonoBehaviour {

public GameObject MapText;
//public GameObject AttachedObject;


void OnTriggerEnter (Collider other){
if (other.gameObject.tag == "Player")
MapText.SetActive (true);
StartCoroutine ("ExplainOff");
}

IEnumerator ExplainOff() {
yield return new WaitForSeconds (5);
MapText.SetActive (false);
}

void Update(){
if(Input.GetKeyDown(KeyCode.M)){
	Application.LoadLevel("Map Menu");
	Cursor.visible = true;
}
}
}
