using UnityEngine;
using System.Collections;

public class killBox : MonoBehaviour 
{
	public bool isColliding = false;

	void Start () 
	{
	
	}

	void Update () 
	{
	
	}
	
	void OnTriggerEnter(Collider colliderObj)
	{
    	if (colliderObj.tag == "player")
		{
			isColliding = true;
		}
			
	}

	void OnTriggerExit(Collider colliderObj)
	{
    	if (colliderObj.tag == "player")
		{
			isColliding = false;
		}
	}	
}
