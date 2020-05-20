﻿using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;

public class BallGlue : MonoBehaviour
{
    public int objCounter = 0;
    public float scale = .5f;
    public float dScale = .2f;
    public Animator anima;
    public Text wintxt;
    
    


    private void Start()
    {
        //This gets the animator component. 
        anima = GetComponent<Animator>();

    }
    


    void Update()
    {
       //This controls the animations that are in the ball. 
        if (Input.anyKey)
        {
            anima.SetBool("isMoving", true);
        }
        else
        {
            anima.SetBool("isMoving", false);
        }
    }


    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "SceneObj")
        {
            //All this proccess controls the counter of the objects, as well as the size of the player ball, with it making it bigger
            objCounter = col.contactCount + objCounter;
            scale = objCounter + dScale;
            gameObject.transform.localScale = new Vector3(gameObject.transform.localScale.x + dScale, gameObject.transform.localScale.y + dScale, gameObject.transform.localScale.z + dScale);
            //In the case the player gets 15 objects the game will thank them, and then quit. 
            if (objCounter >= 15)
            {
                wintxt.text = "Winner!! ";
                Application.Quit();
            }

        }


    }
  



}



