using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class shootBall : MonoBehaviour
{
    public float force = 900.0f;  // plunger force
    public string buttonName = "buttonX"; //assigned input button

    private List<Rigidbody> ballList = new List<Rigidbody>();

// Update is called once per frame
 void Update ()
    {
        if (Input.GetButtonDown(buttonName))
        {
            foreach(Rigidbody ball in ballList)
            {
                ball.AddForce(Vector3.left * force);  // apply the plunger force to the rigid body if the x button is pressed
            }
        }
  }




     void OnTriggerEnter(Collider col)
    {
        Debug.Log("Object Entered");
        if (col.GetComponent<Rigidbody>())
        {
            Debug.Log("Object Has Rigidbody");
            ballList.Add(col.GetComponent<Rigidbody>());
        }
    }



    void OnTriggerExit(Collider col)
    {
        Debug.Log("Object Exited");
        if (col.GetComponent<Rigidbody>())
        {
            Debug.Log("Object Has Rigidbody");
            ballList.Remove(col.GetComponent<Rigidbody>());
        }
    }

}