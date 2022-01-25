using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateTrail : MonoBehaviour
{
    public movement moving;
    public GameObject player;
    public GameObject user;

    void Update()
    {
        if(moving.getRight() == true)
        {
            player.transform.rotation = new Quaternion(30 , 0 , 0 , 0);
            player.transform.position = new Vector3(user.transform.position.x - .1f , user.transform.position.y + .075f , 0);
         
        }
        else
        {
            player.transform.rotation = new Quaternion(-30 , 0 , 0 , 0);
            player.transform.position = new Vector3(user.transform.position.x + .05f , user.transform.position.y - .1f  , 0);
        }
    }
}
