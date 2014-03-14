using UnityEngine;
using System.Collections;

public class playerDeath : MonoBehaviour 
{

	private Vector3 startPosition = Vector3.zero;
	private GameObject[] killboxes;

	void Start () 
	{
		CharacterController controller = GetComponent<CharacterController>();
		startPosition = controller.transform.position;
		killboxes = GameObject.FindGameObjectsWithTag("killbox");
	}
	
	void Update ()
	{
		
// Check if it is colliding with any killbox.
		for (int i = 0; i < killboxes.Length; i++)
		{
    		if (killboxes[i].GetComponent<killBox>().isColliding)
    		{
				KillPlayer ();
        		break;
   			}
		}
	}

// Kill the player! 
	public void KillPlayer ()
	{
		CharacterController controller = GetComponent<CharacterController>();
		controller.transform.position = startPosition;	
	}
}

