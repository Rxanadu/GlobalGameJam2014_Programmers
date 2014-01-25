using UnityEngine;
using System.Collections;

/// <summary>
/// @Usage: place on player child object 
/// </summary>
public class CollisionWith3DObjects : MonoBehaviour {

	public PlayerController playerControl;

	void OnCollisionEnter(Collision	other)
	{
		playerControl.isGrounded=false;
		Debug.Log("3d");
	}

	void OnCollisionExit(Collision other){
		playerControl.isGrounded=false;
		Debug.Log("in air");
	}
}
