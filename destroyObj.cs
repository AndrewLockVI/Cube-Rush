using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyObj : MonoBehaviour
{
    public GameObject obj;
    public GameObject player;

    void FixedUpdate()
    {
        if(obj.transform.position.y - player.transform.position.y < -6 &  obj.transform.position.y > -1000 )
        {

            obj.SetActive(false);

        }
    }
}
