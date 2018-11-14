using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class LiftBoi : MonoBehaviour {

      //public bool animation_bool;
          
		void Update()
					 {
            if(Input.GetKeyDown("b"))
			//if(animation_bool == false)
                     {
                GetComponent<Animation>().Play("Lower");
                     }

                     {
                //animation_bool = true;
                     }
 
 
 
                }
}
