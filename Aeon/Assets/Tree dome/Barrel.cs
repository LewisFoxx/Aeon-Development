using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barrel : MonoBehaviour 
{

	Animation anim;
	private float animSpeed = 0.09f;
	
    void Start()
	{
	anim = GetComponent<Animation>();
	}
	
	void Update()
	{
	anim["BARREL"].speed = animSpeed;
	}
}