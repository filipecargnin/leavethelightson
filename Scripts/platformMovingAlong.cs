using UnityEngine;
using System.Collections;

public class platformMovingAlong : MonoBehaviour 
{


	void Start () 
	{
	
	}
	
	void Update () 
	{

	}
	
	void OnTriggerStay(Collider collider )
	{
 		if(collider.gameObject.tag == "player")
		{
           collider.transform.parent = this.transform;
		}
    }
 
	void OnTriggerExit(Collider collider)
	{
    	if(collider.gameObject.tag == "player")
		{
          collider.transform.parent = null;
		}
	}
}
