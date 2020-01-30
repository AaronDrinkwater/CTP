using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waypoint : MonoBehaviour
{
    private float force = 10.0f;
    private float speed = 4.0f;

    public float acceler;

    bool turn = false;

    // Start is called before the first frame update
    void Start()
    {
        acceler = GetComponent<OVRPlayerController>().Acceleration;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //private void OnCollisionEnter(Collision c)
    //{
    //    if(c.gameObject.tag == "Waypoint")
    //    {
    //        Vector3 dir = c.contacts[0].point - transform.position;
    //        dir = -dir.normalized;

    //        GetComponent<Rigidbody>().AddForce(dir*force);

    //        Debug.Log("I have entered the collider");
    //    }
    //}

    void OnTriggerEnter(Collider other)
    {
        turn = true;
        if (turn = true && other.gameObject.tag == "Waypoint")
        {
            //gameObject.transform.Rotate(0, 90, 0);
            //gameObject.transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(0, 90, 0), speed * Time.deltaTime);
            gameObject.transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(0, 90, 0), Time.deltaTime * speed);
            //transform.rotation = Quaternion.LookRotation();

            Debug.Log("I have entered the collider");
        }

        turn = false;
    }

}
