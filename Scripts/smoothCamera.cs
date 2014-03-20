using UnityEngine;
using System.Collections;
 
//Nao consegui fazer funcionar direito, por isso, nao esta nem ativa. 

public class smoothCamera : MonoBehaviour
{
 
    public GameObject cameraTarget; // object to look at or follow
//    public GameObject player; // player object for moving
 
    public float smoothTime = 0.1f;    // time for dampen
    public bool cameraFollowX = true; // camera follows on horizontal
    public bool cameraFollowY = true; // camera follows on vertical
    public Vector2 velocity; // speed of camera movement
 
	private float difference = 0f;
    private Transform thisTransform; // camera Transform
 
    void Start()
    {
        thisTransform = transform;

    }
 
    void FixedUpdate()
    {
		difference = cameraTarget.transform.position.x - thisTransform.position.x;
		
        if (cameraFollowX)
        {
            thisTransform.position = new Vector3(Mathf.SmoothDamp(thisTransform.position.x, cameraTarget.transform.position.x, ref velocity.x, smoothTime), thisTransform.position.y, thisTransform.position.z);
        }
        if (cameraFollowY)
        {
  			thisTransform.position = new Vector3(thisTransform.position.x, Mathf.SmoothDamp(thisTransform.position.y, cameraTarget.transform.position.y, ref velocity.y, smoothTime) + 1, thisTransform.position.z);
        }
		
		Debug.Log(difference);
    }
}