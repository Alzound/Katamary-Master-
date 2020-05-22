using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class Restart : MonoBehaviour
{
 
   
 

    // Start is called before the first frame update
    //No logre que funcionara :/  
    public void RestartGame()
    {
        if (GameObject.Find("HPlayer").GetComponent<TimerController>().t <= 0 && Input.GetKey(KeyCode.Delete))
        {
            
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

}
 