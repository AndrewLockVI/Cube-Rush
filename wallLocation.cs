using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wallLocation : MonoBehaviour
{
    public float leftConstraint = 0.0f;
    public GameObject wallL;
    void Start()
    {
        leftConstraint = Camera.main.ScreenToWorldPoint( new Vector3(0.0f, 0.0f, 0 - Camera.main.transform.position.z) ).x;
        wallL.transform.position = new Vector3 (leftConstraint , 0 , 0);
        
    }


    public float getLeftEdge()
    {
        return leftConstraint;
    }


}
