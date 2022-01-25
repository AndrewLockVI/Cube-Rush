using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class switchScene : MonoBehaviour
{

    public void gameScene()
    {
        Invoke("gameChanger" , .5f);
        PlayerPrefs.SetInt("runs" , PlayerPrefs.GetInt("runs") + 1);
    }
    void gameChanger()
    {
        SceneManager.LoadScene("game");
    }







    public void menuScene()
    {
        Invoke("menuChange" , .5f);
    }
    void menuChange()
    {
        SceneManager.LoadScene("startMenu");
    }


    public void storeScene()
    {
        Invoke("storeCh" , .5f);
    }
    void storeCh()
    {
        SceneManager.LoadScene("store");
    }



}
