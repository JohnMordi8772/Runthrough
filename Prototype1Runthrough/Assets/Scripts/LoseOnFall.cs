/** John Mordi* 
 * Assignment #2 Prototype #1* 
 * Detects if player falls and declares a gameover*/
 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.UI;

//attach script to player
public class LoseOnFall : MonoBehaviour
{
    //public Text textbox;
    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -1)
        {
            //textbox.text = "You Lose!";
            ScoreManager.gameover = true;
        }
    }
}
