using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMotor : MonoBehaviour {
	private CharacterController controller;
	private Rigidbody2D rigid;
	private Animator animPlay;


	private Vector3 moveVector;
	private Vector3 positionVector;
	private Vector2 v2;
	//private float speed = 3;
	//private float speeda = 7.0f;
	private float speedb = 4;
	float aw, speedd;
	public Text scoreText;
	public Text scoreOverText;
	public Text scoreCoin;
	private float startTime;
	public int wa;
    public AudioSource nabrakSound;
	Pause pause;
	public GameObject pausePanel;

	[SerializeField]
	private GameObject gameOverUI;

	[SerializeField]
	private GameObject gameUI;

	public ScoreManager score;
	//ScoreManager Scorer = new ScoreManager();

	private bool isDead = false;
	// Use this for initialization

	void Start () {
		
		rigid = GetComponent<Rigidbody2D> ();
		animPlay = GetComponent<Animator>();
        startTime = Time.deltaTime + 4;
		gameOverUI.SetActive(false);

	}

	// Update is called once per frame
	void Update () {

		if (isDead) {
			return;
		}
		if (Input.GetKeyDown (KeyCode.Escape)) {
			pausePanel.SetActive (true);
			Time.timeScale = 0;
		}






		//moveVector = Vector3.zero;
		//v2 = Vector2.zero;

		//X Left
		//moveVector.x += Input.GetAxis ("Horizontal") * speeda;
		//positionVector = transform.position;

		/*if (positionVector.x > 2.0f) {
			;
		} else {
			moveVector.x = 1;
		}*/
		//moveVector.x = Mathf.Clamp(moveVector.x,1,0);
		MovePlayer (speedd);

		if (Input.GetMouseButton (0)) {
			if (Input.mousePosition.x > Screen.width / 2) {
				/*moveVector.x = 1 **/ speedd = speedb; 


				//animPlay.SetInteger ("State", 1);
			}
            else
            {
                /*moveVector.x = -1 **/
                speedd = -speedb;

            }

		} else 
			speedd = 0; 
		

		/*if (aw > 5) {
			speedb = 4;
			if (aw > 15) {
				speedb = 5;
				if (aw >25) {
					speedb = 6;
					if (aw >35) {
						speedb = 7;
						if (aw >40) {
							speedb = 8;

						}
					}
				}
			}
		}*/


		//Y Up
		//v2.y = speed;
		if (aw > 6) {
			rigid.velocity = new Vector2 (rigid.velocity.x, speedb);
			//animPlay.SetBool ("Api", true);
		
		}
		//Forward

		//rigid.MovePosition (v2 * Time.deltaTime);

		aw += (Time.deltaTime * 3); //- startTime;


		scoreText.text = (aw + wa).ToString ("0");
		scoreOverText.text = scoreText.text;

        float currentBestScore = PlayerPrefs.GetFloat("BestScore", 0);
        float currentScore = (aw + wa);

        if(currentScore > currentBestScore)
        {
            PlayerPrefs.SetFloat("BestScore", currentScore);
        }

		//scoreCoin.text = wa.ToString("0");

	}


	void MovePlayer (float playerSpeed){
		rigid.velocity = new Vector2(speedd, rigid.velocity.y);
	}



	/*private void OnControllerColliderHit(ControllerColliderHit hit){
		if (hit.point.y > transform.position.y ) {
			Death ();
			//score.OnDeath ();
			//GetComponent<ScoreManager>().OnDeath ();
		}
	}*/

	void OnCollisionEnter2D (Collision2D other){
		if (other.transform.tag == "Halangan") {
			print ("dsad");
			Death ();
		}
	}



	private void Death(){
		animPlay.SetInteger ("State", 8);
		isDead = true;
		rigid.velocity = new Vector2 (rigid.velocity.x, 0);

		//GetComponent<ScoreManager>().OnDeath ();
		gameOverUI.SetActive(true);
		gameUI.SetActive(false);
        //animPlay.SetBool ("Nabrak", true);

        nabrakSound.Play();


	
	}



}
