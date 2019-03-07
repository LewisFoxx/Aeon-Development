using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour {

	private GameObject player;
	private float minClamp = -45;
	private float maxClamp = 45;
	[HideInInspector]
	public Vector2 rotation;
	private Vector2 currentLookRot;
	private Vector2 rotationV = new Vector2 (0, 0);

	public float lookSensistvity = 2;
	public float lookSmoothDamp = 0.1f;

	// Use this for initialization
	void Start () {
		//Access the player GameObject
		player = transform.parent.gameObject;
	}
	
	// Update is called once per frame
	void Update () {
		//Player input from mouse
		rotation.y += Input.GetAxis("Mouse Y") * lookSensistvity;
		//Limit ability to look up and down
		rotation.y = Mathf.Clamp(rotation.y, minClamp, maxClamp);
		//Rotate the character around based on the mouse x position
		player.transform.RotateAround(transform.position, Vector3.up, Input.GetAxis("Mouse X") * lookSensistvity);
		//Smooth the current y rotation for looking up and down
		currentLookRot.y = Mathf.SmoothDamp(currentLookRot.y, rotation.y, ref rotationV.y, lookSmoothDamp);
		//Update the camera x rotation based on values generated.
		transform.localEulerAngles = new Vector3(-currentLookRot.y,0,0);
	}
}
