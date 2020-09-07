/** John Mordi* 
 * Assignment #2 Challenge #1 * 
 * Checks player position and declares gameover if out of bounds */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerOutOfBounds : MonoBehaviour
{
    
    // Update is called once per frame
    void Update()
    {
        //Checks player position
        if(transform.position.y >= 80 || transform.position.y <= -51)
        {
            ScoreManager.gameover = true;
        }
    }
}
