using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetColor : MonoBehaviour
{
    public Material text1;
    public Material text2;
    public Material text3;
    public Material text4;


    void Update()
    {
        string colorChosen = PlayerPrefs.GetString("color");
        if(colorChosen == "red")
        {
            Color red = new Color(0.9490196f , 0.1215686f , 0.04705882f);
            text1.SetColor("_Color" , red);
            text2.SetColor("_Color" , red);
            text3.color = red;
            text4.color = red;

        }
        if(colorChosen == "default" | colorChosen == "")
        {
            Color def = new Color(0.4470588f , 0.9843137f , 1);
            text1.SetColor("_Color" , def);
            text2.SetColor("_Color" , def);
            text3.color = def;
            text4.color = def;
        }






        if(colorChosen == "purple")
        {
            Color purple = new Color(0.6313726f , 0.1529412f , 0.9490196f);
            text1.SetColor("_Color" , purple);
            text2.SetColor("_Color" , purple);
            text3.color = purple;
            text4.color = purple;
        }

        if(colorChosen == "orange")
        {
            Color orange = new Color(1f , 0.3664922f , 0f);
            text1.SetColor("_Color" , orange);
            text2.SetColor("_Color" , orange);
            text3.color = orange;
            text4.color = orange;
        }

        if(colorChosen == "yellow")
        {
            Color yellow = new Color(1 , 0.9058824f , 0.2941177f);
            text1.SetColor("_Color" , yellow);
            text2.SetColor("_Color" , yellow);
            text3.color = yellow;
            text4.color = yellow;
        }





        if(colorChosen == "pink")
        {
            Color pink = new Color(0.9490196f , 0.4745098f , 0.9176471f);
            text1.SetColor("_Color" , pink);
            text2.SetColor("_Color" , pink);
            text3.color = pink;
            text4.color = pink;
        }



        if(colorChosen == "dblue")
        {
            Color dblue = new Color(0.1607843f , 0.2784314f , 0.9490196f);
            text1.SetColor("_Color" , dblue);
            text2.SetColor("_Color" , dblue);
            text3.color = dblue;
            text4.color = dblue;
        }

            if(colorChosen == "green")
        {
            Color green = new Color(0.007843138f , 0.7137255f , 0.08235294f);
            text1.SetColor("_Color" , green);
            text2.SetColor("_Color" , green);
            text3.color = green;
            text4.color = green;
        }
            if(colorChosen == "brown")
        {
            Color brown = new Color(0.6509804f , 0.3215686f , 0.2470588f);
            text1.SetColor("_Color" , brown);
            text2.SetColor("_Color" , brown);
            text3.color = brown;
            text4.color = brown;
        }
















    }
}
