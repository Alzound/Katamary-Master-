using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 



public class TimerController : MonoBehaviour
{
    public Text timerTxt;
    private float startTime; 


    // Start is called before the first frame update
    void Start()
    {
        startTime = Time.time; 
    }

    // Update is called once per frame
    void Update()
    {
        float t = 180- Time.time;
        string minutes = ((int)t / 60).ToString();
        string seconds = (t % 60).ToString("f2");
        timerTxt.text = minutes + ":" + seconds; 
        if(t<=0)
        {
            timerTxt.text = "Has perdido :(";
            Debug.Log("Has perdido");
        }
    }
}
