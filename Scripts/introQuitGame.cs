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
