using UnityEngine;
using System.Collections;

public class playerMovement : MonoBehaviour
{
	private bool running = false;
	private bool jumping = false;
	private bool canJump = true;
	private bool grounded = false;
	private bool facingForward = false;
	private bool facingBack = false;
	
    public float speed = 15f;
	public float runSpeed = 30f;
	public float walkAir = 15f;
	public float runAir = 20f;
    public float gravity = 160f;
	
	private float startHeight = 10f;
	private float maxHeight = 0f;
	private float jumpTime = 0;
	
  	private Vector3 moveDirection = Vector3.zero;

    void Update() 
	{

        CharacterController controller = GetComponent<CharacterController>();
		maxHeight = controller.transform.position.y - startHeight;

		
// Is the player grounded?
		if(controller.isGrounded)
		{
			grounded = true;
			jumping = false;
			canJump = true;
		}
		else
		{
			grounded = false;
		}
		
// Is the player running?
		if(Input.GetButton("Fire1"))
		{
			running = true;
		}
		else
		{
			running = false;
		}
		
//Move
		controller.Move(moveDirection * Time.deltaTime);
		
// Gravity
		moveDirection.y -= gravity * Time.deltaTime;
        
// Walk
        if(grounded && !running)
		{
			moveDirection = new Vector3(0, 0, Input.GetAxis("Horizontal"));
			moveDirection = transform.TransformDirection(moveDirection);
            moveDirection *= speed;	
		}
		
// Run
		if(grounded && running)
		{
			moveDirection = new Vector3(0, 0, Input.GetAxis("Horizontal"));
            moveDirection = transform.TransformDirection(moveDirection);
            moveDirection *= runSpeed;
		}	

// Start jump
		if(Input.GetButton("Jump") && grounded && jumpTime > 0.25)
		{
			jumping = true;
			moveDirection.y += 7;
			startHeight = controller.transform.position.y;
		}
		
//Stop jump
		if(Input.GetButtonUp("Jump"))
		{
			jumping = false;
		}

// Continue jumping, pressure sensitive jump
		if(jumping && Input.GetButton("Jump") && maxHeight < 2 && !running && canJump)
		{
			moveDirection.y += 5;
		}
		else if(jumping && Input.GetButton("Jump") && maxHeight < 2.8 && running && canJump)
		{
			moveDirection.y += 5;
		}
		
		if(maxHeight >= 2 && !running)
		{
			canJump = false;
		}
		else if(maxHeight >= 3.4 && running)
		{
			canJump = false;
		}
			
// Horizontal movement on jump (walk)
		if(!grounded && !running)
		{	
			moveDirection.x = -Input.GetAxis("Horizontal");
			moveDirection.x *= walkAir;
		}
		
// Horizontal movement on jump (run)
		if(!grounded && running)
		{			
			moveDirection.x = -Input.GetAxis("Horizontal");
			moveDirection.x *= runAir;
		}
		
// Time between jumps
		jumpTime += 1 * Time.deltaTime;
		
// Determine facing direction
		if(Input.GetAxis("Horizontal") > 0)
		{
			facingForward = true;
			facingBack = false;
		}
		else if(Input.GetAxis("Horizontal") < 0)
		{
			facingForward = false;
			facingBack = true;
		}
		else
		{

		}
			
// Rotate to face the direction of the movement
		if(facingForward)
		{
			
		}
		
		if(facingBack)
		{

		}
		
    }
}