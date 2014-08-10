//No futuro serao imagens, mas por enquanto coloquei para mostrar os valores.

using UnityEngine;
using System.Collections;

public class playerGUI : MonoBehaviour 
{

	private GameObject player;
	private GameObject light;
	private float duration = 0f;
	
	void Start () 
	{
		player = GameObject.Find("player");
		light = GameObject.Find("player_light");
	}
	
	void Update () 
	{
		duration = light.GetComponent<playerLight>().maxTime - light.GetComponent<playerLight>().timer;
	}
	
		void OnGUI()
	{
		GUI.Label(new Rect(10, 10, 100, 100), "Matches: " + player.GetComponent<matches>().numMatches.ToString());
		GUI.Label(new Rect(10, 30, 100, 100), "Fireflies: " + light.GetComponent<playerLight>().fireflies.ToString());
		GUI.Label(new Rect(10, 50, 100, 100), "Timer: " + duration.ToString());

	}
}
