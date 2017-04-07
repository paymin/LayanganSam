using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingBtn : MonoBehaviour {
	
	[SerializeField]
	public GameObject setting;

	[SerializeField]
	public GameObject settingOff;

	[SerializeField]
	public GameObject BtnOn;

	[SerializeField]
	public GameObject BtnOff;

	public AudioSource sound;

	// Use this for initialization
	void Start () {
		setting.SetActive (false);
		settingOff.SetActive (false);
		BtnOn.SetActive (true);
		BtnOff.SetActive (false);
	}

	// Update is called once per frame
	public void toggleOn(){
		
		setting.SetActive (true);
		settingOff.SetActive (false);
		BtnOff.SetActive (true);
		BtnOn.SetActive (false);
		sound.Play();

	}

	public void toggleOff(){

		setting.SetActive (false);

		sound.Play();
		BtnOff.SetActive (false);
		BtnOn.SetActive (true);
		settingOff.SetActive (true);

	}

}
