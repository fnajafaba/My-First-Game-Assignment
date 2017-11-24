///Flora Najafabadi
//100416736
//SharkController.cs
//Last modified on November 23, 2017 1:28 PM by Flora
//Underwater Battle Game
//Revision 02
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SharkController : MonoBehaviour {
	



	/**
	//Public variables
	[SerializeField]
	private float speed = 0.2f;
	[SerializeField]
	private float startY=5.8f;
	[SerializeField]
	private float endY=-5.8f;
	[SerializeField]
	private float startX = -6.1f;
	[SerializeField]
	private float endX = 6.1f;

	private float xSpeed;

	//private variables
	private Transform _transform;
	private Vector2 _currentPos;

	// Use this for initialization
	void Start () {
		_transform = gameObject.GetComponent<Transform> ();
		_currentPos = _transform.position;
		xSpeed = (float)(Random.Range(-1, 1));
		Reset ();
	}

	// Update is called once per frame
	void Update () {
		_currentPos = _transform.position;
		//move ocean down
		//float xSpeed = (float)(Random.Range(-1, 1));
		_currentPos -= new Vector2 (xSpeed/50f, speed);

		//check if we need to reset
		if (_currentPos.y < endY) {
			//reset
			Reset();
		}
		//apply changes
		_transform.position = _currentPos;

	}


	private void Reset(){

		float x = Random.Range (startX, endX);
		float dy = Random.Range (0, 10);
		_currentPos = new Vector2 (x, startY+dy);
	}
}
**/



	









[SerializeField]
float minYSpeed = -0.2f;
[SerializeField]
float maxYSpeed = 0.4f;
[SerializeField]
float minXSpeed = 0.3f;
[SerializeField]
float maxXSpeed = 0.9f;

private Transform _transform;
private Vector2 _currentSpeed;
private Vector2 _currentPosition;

// Use this for initialization
void Start () {
	_transform = gameObject.GetComponent<Transform> ();
	Reset ();
}

public void Reset(){

	float xSpeed = Random.Range (minXSpeed, maxXSpeed);
	float ySpeed = Random.Range (minYSpeed, maxYSpeed);

	_currentSpeed = new Vector2 (xSpeed, ySpeed);

	float y = Random.Range (-4.2f, 4.2f); 
	_transform.position = 
		new Vector2 (8f+Random.Range (0, -1), y);

}

// Update is called once per frame
void Update () {
	_currentPosition = _transform.position;
	_currentPosition -= _currentSpeed;
	_transform.position = _currentPosition;

	if (_currentPosition.x <= -8f) {
		Reset ();
	}
}
}














