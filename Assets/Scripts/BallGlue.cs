using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class BallGlue : MonoBehaviour
{
    public int objCounter = 0;
    public float scale = .5f;
    public float dScale = .2f;
    public Animator anima;
    


    private void Start()
    {
        anima = GetComponent<Animator>();
    }
    


    void Update()
    {
       
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
            objCounter = col.contactCount + objCounter;
            scale = objCounter + dScale;
            gameObject.transform.localScale = new Vector3(gameObject.transform.localScale.x + dScale, gameObject.transform.localScale.y + dScale, gameObject.transform.localScale.z + dScale);
        }


    }



}



