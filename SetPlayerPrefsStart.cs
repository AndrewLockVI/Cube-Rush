using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetPlayerPrefsStart : MonoBehaviour
{

    void Start()
    {
        PlayerPrefs.SetInt("start" , 0);
    }
}
