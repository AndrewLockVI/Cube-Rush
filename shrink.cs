using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shrink : MonoBehaviour
{

    public GameObject obj;
    public float shrinkRate = -3f;
    public bool shrinking;
    public GameObject player;



    void FixedUpdate()
    {
        if(shrinking == true)
        {
            obj.transform.localScale += new Vector3(0.1f , .1f , .1f) * shrinkRate * Time.deltaTime;
        }

        if(obj.transform.localScale.x < .1)
        {
            obj.SetActive(false);
        }

        if(obj.transform.position.y < player.transform.position.y - .5 & obj.transform.position.y > -1000) 
        {

            shrinking = true;
        }



    }


}
