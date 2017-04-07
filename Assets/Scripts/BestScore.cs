using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BestScore : MonoBehaviour {

    public Text textBestScore;

	// Use this for initialization
	void Start () {
        textBestScore.text = PlayerPrefs.GetFloat("BestScore", 0).ToString("0");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
