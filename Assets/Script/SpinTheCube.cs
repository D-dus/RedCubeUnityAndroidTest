using UnityEngine;
using System.Collections;

public class SpinTheCube : MonoBehaviour {

	public float mSpeed;
	// Use this for initialization
	void Start()
	{
		Screen.sleepTimeout = SleepTimeout.NeverSleep;
	}
	// Update is called once per frame
	void Update () 
	{
//		if (Input.GetKeyDown (KeyCode.Escape))
//			Application.Quit ();
//		transform.Rotate (Vector3.up, mSpeed * Time.deltaTime);
		if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved) 
		{
			// Get movement of the finger since last frame
			Vector2 touchDeltaPosition = Input.GetTouch(0).deltaPosition;
			// Move object across XY plane
			transform.Translate(-touchDeltaPosition.x * mSpeed, -touchDeltaPosition.y * mSpeed, 0);
		}
	}
}
