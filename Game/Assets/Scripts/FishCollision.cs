//Flora Najafabadi
//100416736
//FishCollision.cs
//Last modified on November 23, 2017 1:28 PM by Flora
//Underwater Battle Game
//Revision 02
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishCollision : MonoBehaviour {

	[SerializeField]
	GameController gameController;

	[SerializeField]
	GameObject blood;

	private AudioSource _bubbleSound;

	// Use this for initialization
	void Start () {
		_bubbleSound = gameObject.GetComponent<AudioSource> ();
	}

	// Update is called once per frame
	void Update () {

	}

	public void OnTriggerEnter2D(Collider2D other){


		if (other.gameObject.tag.Equals ("jewelrybox")) {
			Debug.Log ("Collision jewelrybox\n");
			if (_bubbleSound != null) {
				_bubbleSound.Play ();
			}
			//Add points
			gameController.Score+=100;

			//add points
		} else if (other.gameObject.tag.Equals ("enemy")) {
			Debug.Log ("Collision enemy\n");

			var bloodObject = Instantiate (blood);

			bloodObject.GetComponent<Transform> ().position = other.gameObject.GetComponent<Transform> ().position;

			bloodObject.GetComponent<BloodController> ().DestroyMe ();

			//audio souse for my enemy
			other.gameObject.GetComponent<AudioSource> ().Play ();

			//disappear enemy
			other.gameObject.
				GetComponent<SharkController> ()
					.Reset ();
			gameController.Life -= 1;
		}


	}

}

