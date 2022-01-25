using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wrapScreen : MonoBehaviour
{
    public GameObject obj;
  public float leftConstraint = 0.0f;
  public float rightConstraint = 0.0f;
  public float buffer = 0;
  public float distanceZ = 0;
 
  void Awake() 
  {

      leftConstraint = Camera.main.ScreenToWorldPoint( new Vector3(0.0f, 0.0f, 0 - Camera.main.transform.position.z) ).x;
      rightConstraint = Camera.main.ScreenToWorldPoint( new Vector3(Screen.width, 0.0f, 0 - Camera.main.transform.position.z) ).x;
      leftConstraint = Camera.main.ScreenToWorldPoint( new Vector3(0.0f, 0.0f, distanceZ) ).x;
      rightConstraint = Camera.main.ScreenToWorldPoint( new Vector3(Screen.width, 0.0f, distanceZ) ).x;
  }
 
  void Update() 
  {
  
      if (obj.transform.position.x < leftConstraint - buffer)
       { 
      obj.transform.position = new Vector3(rightConstraint + buffer , obj.transform.position.y , obj.transform.position.z);
      }
 
      if (obj.transform.position.x > rightConstraint + buffer) {
      obj.transform.position = new Vector3(leftConstraint + buffer , obj.transform.position.y , obj.transform.position.z);
      }
      
  }
 }