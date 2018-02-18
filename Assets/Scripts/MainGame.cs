using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainGame : MonoBehaviour {

	public static int blocks;
	public static float score;
	public Text txtScore;

	// Use this for initialization
	void Start () {
		blocks = 45;
		score = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if (blocks <= 0) {
			SceneManager.LoadScene ("Menu");
		}
		print (score);
		txtScore.text = score.ToString ();
	}
}
