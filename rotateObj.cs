using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateObj : MonoBehaviour
{
    public GameObject obj;
    public Rigidbody rb;
    private float rotationSpeed;
    private Vector3 movementSpeed;
    public GameObject obstaclePart;
    public GameObject scorePart;
    public GameObject bombPart;
    public GameObject shieldPart;
    public movement moving;




    void Start()
    {
        rotationSpeed = Random.Range(-100 , 100);
        movementSpeed = new Vector3 (Random.Range(-2.5f , 2.5f) * ((obj.transform.position.y / 1000) + 1) , (Random.Range(-2.25f , -1.9f) )* ((obj.transform.position.y / 400) + (moving.getScoreint() / 50)+ 1) , 0);




    }

    void FixedUpdate()
    {
        if(moving.getEnded() == true)
        {
            this.gameObject.SetActive(false);
        }
        obj.transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime * 2);
        rb.velocity = movementSpeed;
    }
    void OnCollisionEnter(Collision col)
    {
        if(col.collider.tag == "obstacle")
        {
           movementSpeed = new Vector3(-movementSpeed.x , movementSpeed.y , movementSpeed.z);
            obj.transform.Rotate(Vector3.forward * -rotationSpeed * Time.deltaTime * 2);

        }
        if(col.collider.tag == "score")
        {
            movementSpeed = new Vector3(-movementSpeed.x , movementSpeed.y , movementSpeed.z);
            obj.transform.Rotate(Vector3.forward * -rotationSpeed * Time.deltaTime * 2);
        }
        if(col.collider.tag == "shield")
        {
            movementSpeed = new Vector3(-movementSpeed.x , movementSpeed.y , movementSpeed.z);
            obj.transform.Rotate(Vector3.forward * -rotationSpeed * Time.deltaTime * 2);
        }
        if(col.collider.tag == "wall")
        {
            movementSpeed = new Vector3(-movementSpeed.x , movementSpeed.y , movementSpeed.z);
            obj.transform.Rotate(Vector3.forward * -rotationSpeed * Time.deltaTime * 2);
        }
        if(col.collider.tag == "explosion")
        {
            this.gameObject.SetActive(false);
            if(this.gameObject.tag == "score")
            {
                Instantiate(scorePart , this.gameObject.transform.position , this.gameObject.transform.rotation);
            }
            if(this.gameObject.tag == "obstacle")
            {
                Instantiate(obstaclePart , this.gameObject.transform.position , this.gameObject.transform.rotation);
            }
            if(this.gameObject.tag == "bomb")
            {
                Instantiate(bombPart , this.gameObject.transform.position , this.gameObject.transform.rotation);
            }
            if(this.gameObject.tag == "shield")
            {
                Instantiate(shieldPart , this.gameObject.transform.position , this.gameObject.transform.rotation);

            }


        }

        if(col.collider.tag == "stop")
        {
            movementSpeed = new Vector3 (0,0,0);
            col.gameObject.SetActive(false);
        }
    }
}
