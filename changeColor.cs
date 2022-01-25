using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeColor : MonoBehaviour
{
     
    public void red()
    {
        PlayerPrefs.SetString("color" , "red");
    } 
    public void Default()
    {
        PlayerPrefs.SetString("color" , "default");
    }

    public void purple()
    {
        PlayerPrefs.SetString("color" , "purple");
    } 

    public void yellow()
    {
        PlayerPrefs.SetString("color" , "yellow");
    } 
    public void orange()
    {
        PlayerPrefs.SetString("color" , "orange");
    } 



    public void green()
    {
        PlayerPrefs.SetString("color" , "green");
    } 

    public void pink()
    {
        PlayerPrefs.SetString("color" , "pink");
    } 
    public void darkBlue()
    {
        PlayerPrefs.SetString("color" , "dblue");
    } 

    public void brown()
    {
        PlayerPrefs.SetString("color" , "brown");
    } 






}
