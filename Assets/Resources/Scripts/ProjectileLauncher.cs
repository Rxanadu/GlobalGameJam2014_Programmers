﻿using UnityEngine;
using System.Collections;

public class ProjectileLauncher : MonoBehaviour {

	public Rigidbody2D rocket;				// Prefab of the rocket.
	public float speed = 20f;				// The speed the rocket will fire at.
	
	
	private PlayerController playerCtrl;		// Reference to the PlayerControl script.
	private Animator anim;					// Reference to the Animator component.
	
	
	void Awake()
	{
		// Setting up the references.
		if(anim!=null)
			anim = transform.root.gameObject.GetComponent<Animator>();
		playerCtrl = transform.root.GetComponent<PlayerController>();
	}
	
	
	void Update ()
	{
		// If the fire button is pressed...
		if(Input.GetButtonDown("Fire1"))
		{
			// ... set the animator Shoot trigger parameter and play the audioclip.
			if(anim!=null)
				anim.SetTrigger("Shoot");
			if(audio!=null)
				audio.Play();

			//Rigidbody2D bulletInstance = Instantiate(rocket, transform.position, 
			//                                         Quaternion.Euler(new Vector3(0,0,0))) as Rigidbody2D;
			//bulletInstance.velocity = new Vector2(speed, 0);
			//bulletInstance.velocity = transform.right*speed;

			// If the player is facing right...
			if(playerCtrl.isFacingRight)
			{
				// ... instantiate the rocket facing right and set it's velocity to the right. 
				Rigidbody2D bulletInstance = Instantiate(rocket, transform.position, Quaternion.Euler(new Vector3(0,0,0))) as Rigidbody2D;
				bulletInstance.velocity = new Vector2(speed, 0);
			}
			else
			{
				// Otherwise instantiate the rocket facing left and set it's velocity to the left.
				Rigidbody2D bulletInstance = Instantiate(rocket, transform.position, Quaternion.Euler(new Vector3(0,0,180f))) as Rigidbody2D;
				bulletInstance.velocity = new Vector2(-speed, 0);
			}
		}
	}
}
