using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {

	public Text scoreText;

	public float scoreCount;

	public float pointsPerSecond;

	public bool scoreIncreasing;

	private bool isDead = false;


	// Use this for initialization
	static void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (isDead)
			return;	

		scoreCount += pointsPerSecond * Time.deltaTime;

		scoreText.text = ((int)scoreCount).ToString ();
	}

	public void OnDeath(){
		Debug.Log ("Bisa");
		isDead = true;
	}



}
