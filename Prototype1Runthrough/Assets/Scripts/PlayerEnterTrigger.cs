/** John Mordi* 
 * Assignment #2 Prototype #1* 
 * Detects player entry into trigger zone and adds points to score*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.UI; no longer needed

//attach to player
public class PlayerEnterTrigger : MonoBehaviour
{
    //set reference in inspector
    //public Text textbox;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("TriggerZone"))
        {
            //textbox.text = "You Win!";
            ScoreManager.score++;
        }
    }
}
