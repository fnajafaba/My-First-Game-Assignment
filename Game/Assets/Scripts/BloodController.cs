//Flora Najafabadi
//100416736
//BloodController.cs 
//Last modified on November 23, 2017 1:28 PM by Flora
//Underwater Battle Game
//Revision 02
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BloodController : MonoBehaviour {
	//destroy the blood game object
	public void DestroyMe(){
		Destroy (this.gameObject, 0.3f);
	}
}
