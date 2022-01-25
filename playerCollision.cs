using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerCollision : MonoBehaviour
{
    private bool shrinking = false;




    void Update()
    {
        if(shrinking == true)
        {
            this.gameObject.transform.localScale += new Vector3(0.1f , .1f , .1f) * -6f * Time.deltaTime;
            Debug.Log("col");

        }
    }
    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.tag == "Player")
        {
            shrinking = true;
        }
    }
}
