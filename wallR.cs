using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wallR : MonoBehaviour
{
  public float rightConstraint = 0.0f;
  public GameObject wallRight;

    void Start()
    {
        rightConstraint = Camera.main.ScreenToWorldPoint( new Vector3(Screen.width, 0.0f, 0 - Camera.main.transform.position.z) ).x;
        wallRight.transform.position = new Vector3 (rightConstraint , 0 , 0);

    }

    public float GetrightEdge()
    {
      return rightConstraint;
    }


}
