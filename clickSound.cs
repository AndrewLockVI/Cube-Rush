using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickSound : MonoBehaviour
{
    public AudioSource click;
    public void clickS()
    {
        click.Play();
    }
        void Update()
    {
      if(PlayerPrefs.GetInt("mute") == 1)
      {
        AudioListener.pause = true;
      }
      else
      {
        AudioListener.pause = false;
      }
    }
}
