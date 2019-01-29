using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportToMap : MonoBehaviour {

public GameObject MapText;
//public GameObject AttachedObject;


void OnTriggerEnter (Collider other){
if (other.gameObject.tag == "Player")
MapText.SetActive (true);
StartCoroutine ("ExplainOff");
}

IEnumerator ExplainOff() {
yield return new WaitForSeconds (10);
MapText.SetActive (false);
}
}
