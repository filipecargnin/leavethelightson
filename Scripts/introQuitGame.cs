// Script que fecha o jogo, ao se pressionar a tecla esc. Depois temos que adicionar o botao do joystick.

using UnityEngine;
using System.Collections;

public class introQuitGame : MonoBehaviour 
{

	void Start () 
	{
	
	}
	
	void Update () 
	{
		if(Input.GetKey(KeyCode.Escape))
		{
			Application.Quit();
		}
	
	}
}
