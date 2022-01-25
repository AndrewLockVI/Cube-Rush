using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class revive : MonoBehaviour
{
    public Text txt1;
   public void reviveSet()
   {
       PlayerPrefs.SetInt("start" , int.Parse(txt1.text));
   }
}
