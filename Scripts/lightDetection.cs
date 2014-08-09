// Script que detecta se o jogador esta na luz. Caso nao esteja, ele ativa o script Darkness. talvez de para juntar esses dois scripts para ficar mais organizado.

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
