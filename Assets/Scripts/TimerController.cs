using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;



public class TimerController : MonoBehaviour
{
    public Text timerTxt;
    private float startTime; 
    public float t;
    public Image img;




    // Start is called before the first frame update
    void Start()
    {
        startTime = Time.time;
        img.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        //This is the timer that i used in order for the player to know how much time he has.
        timerStart();
        timerLost();
      
    }
    public void timerStart()
    {      
      
        t = 60 - Time.time;
        string minutes = ((int)t / 60).ToString();
        string seconds = (t % 60).ToString("f2");
        timerTxt.text = minutes + ":" + seconds;
        if(Input.GetKey(KeyCode.R))
        {
            do
            {
                Debug.Log("Holq");
                t = 60 - Time.time;
                Debug.Log("Holq");

            } while (Input.GetKey(KeyCode.R) != true);
        
        }
    }

    //In case the time runs out the game stops. 
    public void timerLost()
    {
        if (t <= 0)
        {
            timerTxt.text = "You lost :(  \n R-Restart. \n Tab-Quit.";
            img.enabled=true;


        }
        //Uff blessed thy lord, this line of code can access another script and retrieve it's value. 
        //PD: I love you, guy who or woman who created this. 
        if (GameObject.Find("PlayerBall").GetComponent<BallGlue>().objCounter >= 15)
        {
            timerTxt.text = "";
        }
    }

}
