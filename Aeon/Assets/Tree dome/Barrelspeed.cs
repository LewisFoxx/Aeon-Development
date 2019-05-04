using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barrelspeed : MonoBehaviour 
{
	Animation anim;
	private float animSpeed = 0.02f;
	
    void Start()
	{
	anim = GetComponent<Animation>();
	}
	
	void Update()
	{
	anim["barrel"].speed = animSpeed;
	}
}