using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class alwaysOnSound : MonoBehaviour
{
    void Start()
    {
      if(PlayerPrefs.GetInt("start") != 0)
      {
        DontDestroyOnLoad(this.gameObject);  
        PlayerPrefs.SetInt("start" , 0);
        

      }
      else
      {
        Destroy(this.gameObject);
      }
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
