using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class About : MonoBehaviour {

	public GameObject aboutPanel, pauseButton, exitPanel, howPanel;
	public AudioSource sound;
	// Use this for initialization
	void Start () {
		aboutPanel.SetActive (false);
		exitPanel.SetActive (false);
		howPanel.SetActive (false);
	}

	public void tampil()
	{
		aboutPanel.SetActive (true);
		sound.Play ();
	}
	public void tutup()
	{
		aboutPanel.SetActive (false);
		sound.Play ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void buka()
	{
		exitPanel.SetActive (true);
		sound.Play ();
	}
	public void tutup2()
	{
		exitPanel.SetActive (false);
		sound.Play ();
	}
	public void quit()
	{
		Application.Quit ();
	}
	public void howbuka(){
		howPanel.SetActive (true);
		sound.Play ();
	}
	public void howtutup(){
		howPanel.SetActive (false);
		sound.Play ();
	}
}
