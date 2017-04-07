using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class BackMenu : MonoBehaviour {
	public Text reset;
	// Use this for initialization
	public void ChangeToScene (string sceneToChangeTo) {
		SceneManager.LoadScene (sceneToChangeTo);
		Destroy (this);
	}

	public void restartCurrentScene(){
		int scene = SceneManager.GetActiveScene().buildIndex;
		SceneManager.LoadScene(scene,LoadSceneMode.Single);
	}

	public void ChangeToScenee (string sceneToChangeTo) {
		Application.LoadLevel(sceneToChangeTo);
		Destroy (this);
	}

	public void QuitApplication(){
		Application.Quit ();
	}
	public void Reset(){
		reset.text = "0";
	}
}
