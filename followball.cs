using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followball : MonoBehaviour
{
    public GameObject player;
    public GameObject cam;
    


    void Update()
    {
        cam.transform.position = new Vector3 (0 , player.transform.position.y + 2, -10);
    }
}
