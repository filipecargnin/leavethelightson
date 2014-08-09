using UnityEngine;
using System.Collections;

public class introLogo : MonoBehaviour 
{

	private float posX = 0f;
	private float posY = 0f;
	private float width;
	private float height;
	
	public Texture texture;
	
	void Start () 
	{
		width = texture.width;
		height = texture.height;
		posX = Screen.width/2 - width/2;
		posY = Screen.height/2 - height/2;
	}
	
	void Update () 
	{
	
	}
	
		void OnGUI()
	{
		GUI.DrawTexture(new Rect(posX, posY, width, height), texture);
	}
}
