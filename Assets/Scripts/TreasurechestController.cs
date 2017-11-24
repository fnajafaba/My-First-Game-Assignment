//Flora Najafabadi
//100416736
//TreasurechestController.cs
//Last modified on November 23, 2017 1:28 PM by Flora
//Underwater Battle Game
//Revision 02

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreasurechestController : MonoBehaviour {


	//Public variables
	[SerializeField]
	private float speed = 5f;
	[SerializeField]
	private float startY;
	[SerializeField]
	private float endY;
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
		_currentPos -= new Vector2 (xSpeed/100f, speed);

		//check if we need to reset
		if (_currentPos.y < endY) {
			//reset
			Reset();
		}
		//apply changes
		_transform.position = _currentPos;

	}


	//resets the chests
	private void Reset(){

		float x = Random.Range (startX, endX);
		float dy = Random.Range (0, 10);
		_currentPos = new Vector2 (x, startY+dy);
	}
		

}












