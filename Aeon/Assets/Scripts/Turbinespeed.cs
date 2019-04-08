using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turbinespeed : MonoBehaviour 
{
	Animation anim;
	private float animSpeed = 0.02f;
	
    void Start()
	{
	anim = GetComponent<Animation>();
	}
	
	void Update()
	{
	anim["Turbine"].speed = animSpeed;
	}
}