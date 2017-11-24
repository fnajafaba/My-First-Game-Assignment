
//Flora Najafabadi
//100416736
//BackgroundScroll.cs
//Last modified on November 23, 2017 1:28 PM by Flora
//Underwate Battle Game
//Revision 02using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScroll : MonoBehaviour {
	public float speed = 0.5f;

	
	// Update is called once per frame
	void Update () {
		Vector2 offset = new Vector2 (Time.time*speed,0);
		GetComponent<Renderer> ().material.mainTextureOffset = offset;
		
	}
}
