using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.TextCore;
using TMPro;
using System;




public class highScore : MonoBehaviour
{

    public Text text1;
    void Update()
    {


        text1.text = PlayerPrefs.GetInt("total") + "";

        
    }
}
