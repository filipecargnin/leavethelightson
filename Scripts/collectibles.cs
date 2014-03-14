using UnityEngine;
using System.Collections;

public class collectibles : MonoBehaviour 
{

	private GameObject[] lights;
	private GameObject player;
	private float powerUp = 0;
	
	void Start () 
	{
		lights = GameObject.FindGameObjectsWithTag("player_light");
		player = GameObject.Find("player");
	}
	

	void Update () 
	{	
	}
	
	void OnTriggerEnter(Collider collider)
	{
		if(this.tag == "colect_small")
		{
			lights[0].GetComponent<playerLight>().maxTime += 2;
			lights[0].GetComponent<playerLight>().fireflies += 1;
		}
		if(this.tag == "colect_big")
		{
			powerUp ++;
		}
		if(this.tag == "match")
		{
			player.GetComponent<matches>().numMatches += 1;
			
		}
		
		Destroy(gameObject, 0);
	}
}
