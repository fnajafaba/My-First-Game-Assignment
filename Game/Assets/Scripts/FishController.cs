///Flora Najafabadi
//100416736
// FishController.cs
//Last modified on November 23, 2017 1:28 PM by Flora
//Underwater Battle Game
//Revision 02
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishController : MonoBehaviour {

	public float speed=2.0f;
	public float maxPosY=4.6f;
	public float maxPosX=6.1f;
	Vector3 _position;


	// Use this for initialization
	void Start () {
		_position = transform.position;

	}

	// Update is called once per tick
	void FixedUpdate () {
		_position.y += Input.GetAxis ("Vertical")* speed*Time.deltaTime;
		_position.y = Mathf.Clamp (_position.y, -4.6f, 4.6f);
		_position.x += Input.GetAxis ("Horizontal")* speed*Time.deltaTime;
		_position.x = Mathf.Clamp (_position.x, -6.1f, 6.1f);
		transform.position= _position;
	}
}
