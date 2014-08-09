using UnityEngine;
using System.Collections;

public class playerDarkness : MonoBehaviour 
{
	public float timeInDark = 300f;
	public float timer = 0f;
	public AudioClip monstersGrowl;

	public bool darknessSC = false;
	private bool darknessPL = false;
	private GameObject[] playerLights;
	private playerDeath playerDeath;
	
	void Start ()
	{
		playerDeath = GetComponent<playerDeath>();
		playerLights = GameObject.FindGameObjectsWithTag("player_light");
		audio.clip = monstersGrowl;
	}
	
	void FixedUpdate () 
	{
//Check if the player is in the dark
		if(playerLights[0].light.intensity > 0)
		{
			darknessPL = false;
			timer = 0;
		}
		else
		{
			darknessPL = true;
		}
		
		
// If the player is still in the dark, start timer and kill player at the end, if he doesn't move to the light.
		if(darknessPL && darknessSC)
		{
			if(!audio.isPlaying)
			{
				audio.volume = 1;
				audio.Play();
			}
			
			if(timer < timeInDark)
			{
				timer ++;
			}
			else
			{
				timer = 0;
				Debug.Log("Dead");
				darknessPL = false;
				darknessSC = false;
				playerDeath.KillPlayer();		
			}
		}
		else
		{
			if(audio.isPlaying)
			{
				audio.volume -= 2f * Time.deltaTime;
				
				if(audio.volume == 0)
				{
					audio.Stop();
				}
			}
		}
	}
}
