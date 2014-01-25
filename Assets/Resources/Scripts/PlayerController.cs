using UnityEngine;
using System.Collections;

/// <summary>
/// controls how player moves around world, 
/// 	interacts with world, attacks enemies
/// @Usage: Place on player object
/// </summary>
public class PlayerController : MonoBehaviour {

	public float maxSpeed = 5f;
	public float jumpForce = 100f;
	public float moveForce = 20f;

	public bool isGrounded =false;
	public bool is2D = true;
	public bool isFacingRight =true;
	public bool controlPlayer = true;
	
	// Update is called once per frame
	void FixedUpdate () {
		float horizontalMovement = Input.GetAxis ("Horizontal");

		print ("Horizontal Movement: "+horizontalMovement);

		if(controlPlayer){
			if(is2D){
				MovePlayer2D ();
				Jump2D ();

				//flip player around
				// If the input is moving the player right and the player is facing left...
				if(horizontalMovement > 0 && !isFacingRight)
					// ... flip the player.
					FlipSprite();
				// Otherwise if the input is moving the player left and the player is facing right...
				else if(horizontalMovement < 0 && isFacingRight)
					// ... flip the player.
					FlipSprite();
			}
			else{
				MovePlayer ();
				Jump ();

				//flip player around
				// If the input is moving the player right and the player is facing left...
				if(horizontalMovement > 0 && !isFacingRight)
					// ... flip the player.
					FlipObject();
				// Otherwise if the input is moving the player left and the player is facing right...
				else if(horizontalMovement < 0 && isFacingRight)
					// ... flip the player.
					FlipObject();
			}
		}
	}

	void OnCollisionEnter2D(Collision2D other){
		isGrounded=true;
		Debug.Log("grounded");
	}

	void OnCollisionExit2D(Collision2D other){
		isGrounded=false;
		Debug.Log("in air");
	}

	void OnCollisionEnter(Collision other){
		isGrounded=true;
		Debug.Log("grounded");
	}
	
	void OnCollisionExit(Collision other){
		isGrounded=false;
		Debug.Log("in air");
	}

	void MovePlayer2D(){
		float horizontalMovement = Input.GetAxis ("Horizontal");
		Vector2 movement = new Vector2(horizontalMovement, 0);
		
		rigidbody2D.AddForce(movement * moveForce);
	}

	void Jump2D(){
		Vector2 jumpVelocity = new Vector2(0, jumpForce);
		if(Input.GetButtonDown ("Jump") && isGrounded)
			rigidbody2D.AddForce(jumpVelocity);
	}

	void MovePlayer(){
		float horizontalMovement = Input.GetAxis ("Horizontal");
		Vector2 movement = new Vector2(horizontalMovement, 0);
		
		rigidbody.AddForce(movement * moveForce);
	}
	
	void Jump(){
		Vector2 jumpVelocity = new Vector2(0, jumpForce);
		if(Input.GetButtonDown ("Jump") && isGrounded)
			rigidbody.AddForce(jumpVelocity);
	}

	void FlipSprite(){
		// Switch the way the player is labelled as facing.
		isFacingRight = !isFacingRight;
		
		// Multiply the player's x local scale by -1.
		Vector3 playerScale = transform.localScale;
		playerScale.x *= -1;
		transform.localScale = playerScale;
	}

	void FlipObject(){
		isFacingRight = !isFacingRight;

		Vector3 playerRotation = transform.rotation.eulerAngles;
		playerRotation.y *= -1;
		transform.rotation = Quaternion.Euler (playerRotation);
	}
}
