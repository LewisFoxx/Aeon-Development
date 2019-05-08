using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashLight : MonoBehaviour {
		
	public Light thelight;
	public bool on = true;
	
	// Use this for initialization
	void Start () {
		on = true;
	}
	
	// Update is called once per frame
	void Update ()
    {
		if (Input.GetKeyDown(KeyCode.F))
		{
			if(on == true)
			{
				thelight.enabled = false;
				on = false;
			} 
			else if(on == false)
			{
				thelight.enabled = true;
				on = true;
			}
	    }
    }
}