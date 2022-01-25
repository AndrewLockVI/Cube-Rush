using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy : MonoBehaviour
{

public GameObject player2;
    void Update()
    {
        if(this.gameObject.transform.position.y < player2.transform.position.y - .5 &  this.gameObject.transform.position.y > -1000 )
        {
            this.gameObject.SetActive(false);
        }
    }
}
