using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sounds : MonoBehaviour
{

    public AudioSource audioStart, backSound;
    bool muted;

    [SerializeField]
    GameObject OFF, ON;


    // Use this for initialization
    void Start()
    {
        SetSoundState();
    }

    // Update is called once per frame
    void Update()
    {
        //        if (muted)
        //        {
        //            AudioListener.volume = 0;
        //            OFF.SetActive(true);
        //            ON.SetActive(false);
        //        }
        //        else if (!muted)
        //        {
        //            AudioListener.volume = 1;
        //            OFF.SetActive(false);
        //            ON.SetActive(true);
        //        }
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
