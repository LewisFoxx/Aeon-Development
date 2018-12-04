using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class OpeningLift : MonoBehaviour {

      //public bool animation_bool;
          
		void Update()
					 {
            if(Input.GetKeyDown("b"))
			//if(animation_bool == false)
                     {
                GetComponent<Animation>().Play("Up");
                     }

                     {
                //animation_bool = true;
                     }
 
 
 
                }
}
