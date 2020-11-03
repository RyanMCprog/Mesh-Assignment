using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Adventurer : MonoBehaviour
{
    public Animator animator; //Player animator component

    public float speed = 1; //how fast the player moves

    public bool Turning = false; //for when the player is turning

    //float numberOfTurns = 20; //how many times the turning animation loops

    Vector3 initialForward;

    Vector3 curretForward;

    // Update is called once per frame
    void Update()
    {
        //if they are not turn they will continusly move forward
        if(!Turning)
        {
            transform.position += transform.forward * speed * Time.deltaTime;

            animator.SetFloat("Speed", speed);
        }
        else
        {
            curretForward = transform.forward;
            float AngleBetween = Vector3.Angle(initialForward, curretForward);
            //Vector3 AngleBetween = (initialForward - curretForward);
            if(AngleBetween >= 15f)
            {
                Turning = false;
            }
        }
        
    }



    //increases the players turning angle

    //public void OnTurnComplete()
    //{
        //if(numberOfTurns == 0)
        //{
            //Turning = false;
        //}
        //else
        //{
            //numberOfTurns -= 1;
        //}
    //}

    public void IsTurning()
    {
        initialForward = transform.forward;
        Turning = true;
    }
}
