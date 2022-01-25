using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class getHigh : MonoBehaviour
{
    public GameObject[] colors;
    void Start()
    {



        if(PlayerPrefs.GetInt("total") >= 5)
        {
            colors[1].SetActive(false);
        }
        if(PlayerPrefs.GetInt("total") >= 10)
        {
            colors[2].SetActive(false);
        }
        if(PlayerPrefs.GetInt("total") >= 25)
        {
            colors[3].SetActive(false);
        }
        if(PlayerPrefs.GetInt("total") >= 45)
        {
            colors[4].SetActive(false);
        }
        if(PlayerPrefs.GetInt("total") >= 60)
        {
            colors[5].SetActive(false);
        }
        if(PlayerPrefs.GetInt("total") >= 75)
        {
            colors[6].SetActive(false);
        }
        if(PlayerPrefs.GetInt("total") >= 100)
        {
            colors[7].SetActive(false);
        }
        if(PlayerPrefs.GetInt("total") >= 125)
        {
            colors[8].SetActive(false);
        }








    }

    
}
