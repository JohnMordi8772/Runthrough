/** John Mordi* 
 * Assignment #2 Prototype #1* 
 * Detects player entry into trigger zone and adds 1 point*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//attach to triggerzone
public class TriggerZoneAddScoreOnce : MonoBehaviour
{
    private bool triggered = false;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player") && !triggered)
        {
            triggered = true;
            ScoreManager.score++;
        }
    }
}
