using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class getShield : MonoBehaviour
{
    public movement move;
    public GameObject[] shields;



    void Update()
    {
        int shield = move.GetShield();
        for(int i = 0 ; i <= shield ; ++i )
        {
            shields[i].SetActive(true);
        }
        for (int i = shield ; i < shields.Length; ++i)
        {
            shields[i].SetActive(false);
        }



    }
}
