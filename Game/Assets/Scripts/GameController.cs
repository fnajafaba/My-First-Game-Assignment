//Flora Najafabadi
//100416736
//GameController.cs
//Last modified on November 23, 2017 1:28 PM by Flora
//Underwater Battle Game
//Revision 02
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour {

	[SerializeField]
	Text lifeLabel;
	[SerializeField]
	Text scoreLabel;
	[SerializeField]
	Text gameOverLabel;
	[SerializeField]
	Text highScoreLabel;
	[SerializeField]
	Button resetBtn;
	[SerializeField]
	GameObject fish;


	private int _score = 0;
	private int _life = 3;

	//getter and setter for score
	public int Score{
		get{ return _score; }
		set{ 
			_score = value;
			scoreLabel.text = "Scorefh: " + _score;
		}

	}

	//getter and setter for life
	public int Life{
		get{ return _life; }
		set{ 
			_life = value;


			if (_life <= 0) {
				//game over
				gameOver();
			}else{
				lifeLabel.text = "Life: " + _life;
			}
		}
	}

	//initializing for score and life
	private void initialize(){

		Player.Instance.Score = 0;
		Player.Instance.Life = 3;

		//set activity for lables in the begging of game
		gameOverLabel.gameObject.SetActive (false);
		highScoreLabel.gameObject.SetActive (false);
		resetBtn.gameObject.SetActive (false);

		lifeLabel.gameObject.SetActive (true);
		scoreLabel.gameObject.SetActive (true);
	}

	//set activity for lables when game is over
	public void gameOver(){
		gameOverLabel.gameObject.SetActive (true);
		highScoreLabel.gameObject.SetActive (true);

		highScoreLabel.text = "Your highscore is: " + _score.ToString();
		resetBtn.gameObject.SetActive (true);

		lifeLabel.gameObject.SetActive (false);
		scoreLabel.gameObject.SetActive (false);

		//set fish to not active in screen
		fish.gameObject.SetActive (false);

	}

	// Use this for initialization
	void Start () {
		Player.Instance.gCtrl = this;
		initialize ();
	}

	// Update is called once per frame
	void Update () {

	}

	//reset button click
	public void ResetBtnClick(){

		SceneManager.
		LoadScene (
			SceneManager.GetActiveScene ().name);

	}

	//updating UI
	public void updateUI(){

		scoreLabel.text = "Score: " + Player.Instance.Score;
		lifeLabel.text = "Life: " + Player.Instance.Life;
	}


}