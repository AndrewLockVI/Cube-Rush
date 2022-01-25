using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class movement : MonoBehaviour
{
    private bool right;
    public Rigidbody ball;
    public GameObject ball1;
    public float speed;
    public float leftandRight;
    private float forwardInit;
    public GameObject deathParticle;
    public GameObject scoreParticle;
    public GameObject bombPart;

    public GameObject canvasRe;
    public GameObject shieldPart;
    public GameObject shieldPickup;
    public int shields = 0;
    public GameObject shield;
    public scoreTracker scoreChange;
    private float shieldBlow;
    public bool justColl = false;
    public GameObject explosion1;
    public float shieldUp;
    public bool shieldAdd = false;
    public GameObject textScore;
    private bool ended = false;
    public GameObject WallL;
    public GameObject WallR;


    public AudioSource audioplay;
    public AudioSource wallCollision;
    public AudioSource death;
    public Text score;
    private int scoreint;



    void Start()
    {
        right = true;
        forwardInit = speed;
        Application.targetFrameRate = 300;
        scoreint = PlayerPrefs.GetInt("start");
        Debug.Log(scoreint);


    }
    public int getScoreint()
    {
        return scoreint;
    }

    void Update()
    {


  

        speed = forwardInit * ((scoreint / 90) + (ball.transform.position.y / 500) + 1);
        if(shields > 0)
        {
            shield.SetActive(true);
        }
        else
        {
            shield.SetActive(false);
        }

        
        if(Input.GetKeyDown("space"))
        {
            audioplay.Play();
            if(right == true)
            {
              right = false;
            }
            else
            {
                right = true;
            }
            Vector3 pos = ball.transform.position;
            pos.z = 1;
            pos.y = pos.y + .41f;

        }


        
        if(right == true )
        {
            ball.velocity = new Vector3(leftandRight , speed , 0);
        }
        else if(right == true)
        {
            ball.velocity = new Vector3(0 , speed , 0);
        }
        if(right == false )
        {
            ball.velocity = new Vector3(-leftandRight , speed , 0);
        }
        else if(right == false)
        {
            ball.velocity = new Vector3(0 , speed , 0);
        }



        if(Input.touchCount > 0)
        {
            
            Touch touch = Input.GetTouch(0);
            if(touch.phase == TouchPhase.Began)
            {
                audioplay.Play();
                if(right == true)
                {
                    right = false;
                }
                else
                {
                    right = true;
                }
            Vector3 pos = ball.transform.position;
            pos.z = 1;
            pos.y = pos.y + .41f;

            }
        }

        if(justColl == true)
        {
            shieldBlow += Time.deltaTime;
        }
        if(shieldBlow > .4)
        {
            justColl = false;
        }

        if(shieldAdd == true)
        {
            shieldUp += Time.deltaTime;
        }
        if(shieldUp > .1f)
        {
            shieldAdd = false;
        }
       





    }

    void OnCollisionStay(Collision col)
    {
            if(col.collider.tag == "wall")
            {
                if(ball.transform.position.x > 0)
                {
                    wallCollision.Play();
                    right = false;
                }
                else
                {
                right = true;
                wallCollision.Play();
                }
            }
    }

     void OnCollisionEnter(Collision col)
        {
            if(col.collider.tag == "obstacle")
            {
                death.Play();
            }


            if(col.collider.tag == "obstacle" & justColl == false)
            {

                col.gameObject.SetActive(false);
                if(shields < 1 & justColl == false)
                {
                ball1.SetActive(false);
                Instantiate(deathParticle , ball1.transform.position , ball1.transform.rotation);
                Invoke("canvasAct" , .5f);
                
                }
                else
                {
                    shields -= 1;
                    justColl = true;
                    shieldBlow = 0;
                    Instantiate(shieldPart , ball1.transform.position , ball1.transform.rotation);

                }

            }
            else if(col.collider.tag == "obstacle")
            {
                col.gameObject.SetActive(false);
            }
            if(col.collider.tag == "score")
              {

                col.gameObject.SetActive(false);
                Instantiate(scoreParticle , col.transform.position , ball1.transform.rotation);
                scoreChange.setScore(5);
              }
            if(col.collider.tag == "shield" & shieldAdd == false)
              {

                col.gameObject.SetActive(false);
                Instantiate(shieldPickup , col.transform.position , ball1.transform.rotation);
                shields += 1;
                scoreChange.setScore(1);
                shieldAdd = true;
                shieldUp = 0f;
              }
                if(col.collider.tag == "bomb")
              {

                col.gameObject.SetActive(false);
                Instantiate(bombPart , col.transform.position , ball1.transform.rotation);
                scoreChange.setScore(1);
                Instantiate(explosion1 , col.transform.position , ball1.transform.rotation);




              }
        }


        public void SetShield()
        {
            shields += 1;
        }
        public int GetShield()
        {
            return shields;
        }

        void canvasAct()
        {
            canvasRe.SetActive(true);
            textScore.SetActive(false);
            Invoke("wallG" , .2f);

            ended = true;
        }

        void wallG()
        {
            WallL.SetActive(false);
            WallR.SetActive(false);
        }

        public bool getEnded()
        {
            return ended;
        }

        public bool getRight()
        {
            return right;
        }
}
