using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddles : MonoBehaviour
{
    public float restPos = 0f;
    public float pressPos = 90f;
    public float hitStrength = 5000f;
    public float damp = 75f;
    HingeJoint hinge;
    public string input;

    void Start()
    {
        hinge = GetComponent<HingeJoint>();
        hinge.useSpring = true;
    }

    
    void Update()
    {
        JointSpring spring = new JointSpring();
        spring.spring = hitStrength;
        spring.damper = damp;

        if (Input.GetAxis(input) == 1)
        {
            spring.targetPosition = pressPos;
        } else {
            spring.targetPosition = restPos;
        }
        hinge.spring = spring;
        hinge.useLimits = true;
    }
}
