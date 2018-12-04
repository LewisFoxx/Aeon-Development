using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour {

public GameObject item;
 // Use this for initialization
     void Start () {
     
 }
 
 // Update is called once per frame
 void Update ()
 {
     NewMethod();
 }
 private void NewMethod()
 {
     Destroy(item, 8); //you have 15 seconds before the objects deletes itself
 }
}
