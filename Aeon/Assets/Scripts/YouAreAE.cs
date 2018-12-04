using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YouAreAE : MonoBehaviour {

	public AudioClip SoundToPlay;
	public float Volume;
	AudioSource audio; 
	public bool alreadyplayed = false;
	void Start()
	{
		audio =  GetComponent<AudioSource>();
	}
	
	void OnTriggerEnter()
	{
		if (!alreadyplayed)
		{
			audio.PlayOneShot(SoundToPlay, Volume);
			alreadyplayed = true;
		}
	}
}
