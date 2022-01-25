using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartUp : MonoBehaviour
{
    void Start()
    {
        PlayerPrefs.SetInt("start" , 1);
        SceneManager.LoadScene("startMenu");
    }


}
