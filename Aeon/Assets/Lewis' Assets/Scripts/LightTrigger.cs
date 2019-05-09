using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightTrigger : MonoBehaviour {

    public GameObject Light;


    void OnTriggerEnter ()
    {
        Light.SetActive (true);
    }
		
}
