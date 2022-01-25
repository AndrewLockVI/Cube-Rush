using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnObj : MonoBehaviour
{


    public GameObject obstacle;
    public GameObject scoreObj;
    public GameObject shieldObj;
    public GameObject player;
    private float position;
    private float spawnedIn = 0;
    public int spawnDistance;
    private bool edgeSpawn = false;
    private float timer;

    public GameObject leftSide;
    public GameObject rightSide;
    public float right;
    public float left;
    public GameObject bomb;
    private float closer;
    private int guaranteeSpawn = 15;
    private int spawned;
    private int scoreint;


    void Start()
    {
        right = rightSide.transform.position.x - (rightSide.transform.localScale.x / 2f);
        left = leftSide.transform.position.x - (leftSide.transform.localScale.x / 2f);
        scoreint = PlayerPrefs.GetInt("start");

    }
    void Update()
    {
         
        if(edgeSpawn == true)
        {
            timer = timer + Time.deltaTime;
        }
        if(timer > .5)
        {
            edgeSpawn = false;
            timer = 0;
        }

        if(player.transform.position.y < 400)
        {
        closer = spawnDistance - ((player.transform.position.y / 600) +  (scoreint / 50));
        }





        position = player.transform.position.y;
        if(position > spawnedIn * closer)
        {
            if(spawnedIn < 30)
            {
                spawn();
            }
            else if(spawnedIn < 90)
            {
                spawn();

            }
            else if(spawnedIn < 150)
            {
                spawn();
            }
            else if(spawnedIn < 250)
            {
                spawn();
            }
            else
            {
                spawn();
                      
            }
            
            spawnedIn += 1;
        }
        
    }


    void spawn()
    {
        Vector3 spawnPoint = new Vector3 (Random.Range(-1 , 1) , closer * spawnedIn + 10 , 0f);
        if(player.transform.position.x > right - .1 & edgeSpawn == false)
        {
            spawnPoint.x = right;
            edgeSpawn = true;
        }
        if(player.transform.position.x < left + .1 & edgeSpawn == false)
        {
            spawnPoint.x = left;
            edgeSpawn = true;
        }



        float rnd = Random.Range(0 , 100);




        


        if(rnd < 96 & spawned <= guaranteeSpawn)
        {
            spawned += 1;
            Instantiate(obstacle , spawnPoint , new Quaternion(0,0,0,0));
        }
        else
        {
            
            spawned = 0;
            Instantiate(shieldObj , spawnPoint , new Quaternion(0,0,0,0));
            

        }
    }
}
