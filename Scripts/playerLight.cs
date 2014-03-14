// Caso eu coloque mais luzes para iluminar o player, terei q criar for loops para cada luz. Alterar aqui, no collectibles e no playerDarkness.
//
//
//


using UnityEngine;
using System.Collections;

public class playerLight : MonoBehaviour {

	public float maxTime = 0f;
	public bool lit = false;
	public float fireflies = 0f;
	public float timer = 0f;
	
	private Light thisLight;
	private float rate = 0f;
	private float intensity = 0f;
	private GameObject player;

	
	void Start ()
	{
		thisLight = this.GetComponent<Light>();
		intensity = thisLight.intensity;
		thisLight.intensity = 0f;
		rate = intensity * 0.6f;
		player = GameObject.Find("player");
	}
	
	void FixedUpdate () 
	{

// Check if the player has matches. ***********If he has, take one away.
		if(player.GetComponent<matches>().numMatches > 0)
		{
			if(Input.GetButtonDown("Fire2") && !lit)
			{
				timer = 0;
				lit = true;
				thisLight.intensity = intensity;
				
				player.GetComponent<matches>().numMatches -= 1;
			}
		}
		
// Start timer and turn off the light at the end
		if(timer < maxTime && lit)
       	{
           	timer++;
      	}
		else
		{
			timer = 0;
			lit = false;
			thisLight.intensity = Mathf.MoveTowards(thisLight.intensity, 0, Time.deltaTime * rate);
		}
	}
}
