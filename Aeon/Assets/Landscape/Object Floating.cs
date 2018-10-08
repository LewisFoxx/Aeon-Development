using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectFloating : MonoBehaviour {

	var floatup;

    
    function Start() {
        floatup = false;
    }
    
    function Update() {
        if (floatup) {
            floatingup();
        }
        else if (!floatup) {
            floatingdown();
        }
        
    }
    
    function floatingup() {
        transform.position.y = (transform.position.y + (0.4 * Time.deltaTime));
        yield WaitForSeconds;
        1;
        floatup = false;
    }
    
    function floatingdown() {
        transform.position.y = (transform.position.y - (0.4 * Time.deltaTime));
        
        yield WaitForSeconds;
        1;
        floatup = true;
	}
}