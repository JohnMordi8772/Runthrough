/** John Mordi* 
 * Assignment #2 Challenge #1 * 
 * manages the conditions for wins/losses and adjusts textbox repectively*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropellerSpin : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        //makes propeller rotate about the z-axis
        transform.Rotate(new Vector3(0,0,10));
    }
}
