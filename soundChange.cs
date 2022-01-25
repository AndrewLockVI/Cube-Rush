using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundChange : MonoBehaviour
{
    public GameObject soundOn;
    public GameObject soundOff;

    void Update()
    {
        if(PlayerPrefs.GetInt("mute") == 1)
        {
            soundOff.SetActive(true);
            soundOn.SetActive(false);
        }
        else
        {
            soundOff.SetActive(false);
            soundOn.SetActive(true);
        }
    }

    public void SetMute()
    {
        PlayerPrefs.SetInt("mute" , 1);
    }
    public void Unumte()
    {
        PlayerPrefs.SetInt("mute" , 0);
    }
}
