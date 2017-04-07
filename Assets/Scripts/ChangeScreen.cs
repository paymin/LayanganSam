using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class ChangeScreen : MonoBehaviour {

	public Text reset;

	void start(){
		
	}
	public void ChangeToScene (string sceneToChangeTo){
		Application.LoadLevel (sceneToChangeTo);
		Time.timeScale = 1;
	}

	public void Reset (){
		reset.text = "0";
	}

	public void QuitApplication (){
		Application.Quit();
	}

}
