using UnityEngine;
using System.Collections;

public class introPressStart : MonoBehaviour 
{
	private float posX = 0f;
	private float posY = 0f;
	private float width = 342f;
	private float height = 100f;
	private GUIStyle style;
	
	public GUISkin skin;
	
	void Start () 
	{
		
//check for the size of the screen and resize the image accordingly
		
//		width = (width * Screen.width)/1920;
//		height = (height * Screen.width)/1080;
//		
		posX = Screen.width/2 - width/2;
		posY = Screen.height/2 - height/2 + Screen.height/3;
		


	}
	
	void Update () 
	{
		if(Input.GetKey(KeyCode.KeypadEnter) || Input.GetKey(KeyCode.Return))
		{
			Application.LoadLevel("prototype");
		}
		
	}
	
	void OnGUI()
	{
		GUI.skin = skin;
		if(GUI.Button(new Rect(posX, posY, width, height),""))
		{
			Application.LoadLevel("prototype");
		}
	}
}
