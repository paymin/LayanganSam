using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{

    public GameObject pauseButton, pausePanel;
    public AudioSource audioStart, backSound;
    bool muted;

    [SerializeField]
    GameObject OFF, ON;
    // Use this for initialization
    public void Start()
    {
        UnPause();
        SetSoundState();
    }

    // Update is called once per frame
    public void Update()
    {
        //        if (muted)
        //        {
        //            AudioListener.volume = 0;
        //            soundOff.SetActive(true);
        //            soundOn.SetActive(false);
        //        }
        //        else if (!muted)
        //        {
        //            AudioListener.volume = 1;
        //            soundOff.SetActive(false);
        //            soundOn.SetActive(true);
        //        }
    }


    public void UnPause()
    {
        pausePanel.SetActive(false);
        pauseButton.SetActive(true);
        Time.timeScale = 1;
        //        backSound.Play();
    }

    public void OnPause()
    {
        pausePanel.SetActive(true);
        pauseButton.SetActive(false);
        Time.timeScale = 0;
        //       backSound.Pause();
    }
    public void UnPause2()
    {
        Time.timeScale = 1;
    }

    //    public void Mute()
    //    {
    //        muted = !muted;
    //    }

    public void ToggleSound()
    {
        if (PlayerPrefs.GetInt("Muted", 0) == 0)
        {
            PlayerPrefs.SetInt("Muted", 1);
        }
        else
        {
            PlayerPrefs.SetInt("Muted", 0);
        }
        SetSoundState();
    }

    private void SetSoundState()
    {
        if (PlayerPrefs.GetInt("Muted", 0) == 0)
        {
            AudioListener.volume = 1;
            ON.SetActive(true);
            OFF.SetActive(false);
        }
        else
        {
            AudioListener.volume = 0;
            ON.SetActive(false);
            OFF.SetActive(true);
        }
    }
}
