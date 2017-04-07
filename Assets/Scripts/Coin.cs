using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour {

	PlayerMotor playerMotor;
    public AudioSource soundCoin;

    // Use this for initialization
    void Start () {
		playerMotor = GameObject.Find ("Player").GetComponent<PlayerMotor> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D (Collider2D other){
		if (other.transform.tag == "Player") {
			playerMotor.wa++;
            soundCoin.Play();
            Destroy (gameObject);
		}
	}
}
