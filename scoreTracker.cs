using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreTracker : MonoBehaviour
{
    public Text score;
    private int currentScore;
    public float timeScore;
    private float timer;
    public GameObject player1;
    public Text score2;
    private bool scoreTracked = false;
    public GameObject helper;
    


    void Start()
    {
        currentScore = PlayerPrefs.GetInt("start");
        if(PlayerPrefs.GetInt("start") > 0)
        {
            PlayerPrefs.SetInt("revive" ,  1);
            helper.SetActive(false);
        }
        else
        {
            PlayerPrefs.SetInt("revive" , 0);
        }

        PlayerPrefs.SetInt("start" , 0);
    }
    void Update()
    {
        if(timer < timeScore)
        {
            timer += Time.deltaTime;
        }   
        else if(player1.activeInHierarchy == true)
        {
            currentScore += 1;
            timer = 0;
        }
        if(score.IsActive() == false)
        {
            score2.text = currentScore.ToString();
        }


        if(player1.activeInHierarchy == false & scoreTracked == false & currentScore > PlayerPrefs.GetInt("total")) 
        {
            PlayerPrefs.SetInt("total" , currentScore);
            scoreTracked = true;
            
                Social.ReportScore(PlayerPrefs.GetInt("total") , GPGSIds.leaderboard_high_score,(success) =>
                {
                    if(!success) Debug.LogError("Unable to post highscore");
                });

        }








        
        score.text = currentScore.ToString();

        if(player1.activeInHierarchy == true)
        {
            scoreTracked = false;
        }
    }


    public void setScore(int scoreAdd)
    {
        currentScore += scoreAdd;
    }
}
