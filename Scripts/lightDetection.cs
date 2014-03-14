using UnityEngine;
using System.Collections;

public class lightDetection : MonoBehaviour 
{
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
			GameObject.Find("player").GetComponent<playerDarkness>().darknessSC = false;
			GameObject.Find("player").GetComponent<playerDarkness>().timer = 0;
		}
			
	}

	void OnTriggerExit(Collider colliderObj)
	{
    	if (colliderObj.tag == "player")
		{
			GameObject.Find("player").GetComponent<playerDarkness>().darknessSC = true;
		}
	}
}
