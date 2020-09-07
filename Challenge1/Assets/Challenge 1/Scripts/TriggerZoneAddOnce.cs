/** John Mordi* 
 * Assignment #2 Challenge #1 * 
 * detects player in trigger zone and increases score by one*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerZoneAddOnce : MonoBehaviour
{
    private bool triggered = false;
    private void OnTriggerEnter(Collider other)
    {
        //Checks object in trigger and adjusts score once
        if(other.CompareTag("Player") && !triggered)
        {
            triggered = true;
            ScoreManager.score++;
        }
    }
}
