using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerDamage : MonoBehaviour {

	//Use this to refrence the text in the canvas
	public Text healthPanel;
	//Sets the default health to 100
	public int health = 100;

	// Use this for initialization
	private void Start () {
		//Sets the health etxt at the start, we pass 0 as we don't want to remove the health.
		ApplyDamage(0);
	}
	
	// Update is called once per frame
	void ApplyDamage (int damage) {
		//Checks we have attached a health panel and our health is greater than 0
		if (healthPanel != null && health > 0) {
			//Stores the current health and subtracts the damage value
			health = health - damage;
			//Sets the text on our panel
			healthPanel.text = health.ToString ();

		}
	}
}
