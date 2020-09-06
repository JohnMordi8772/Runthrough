/** John Mordi* 
 * Assignment #2 Prototype #1* 
 * Controls player model based on player input*/
 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 20;
    public float turnSpeed = 40;
    public float horizontalInput;
    public float forwardInput;
    
    // Update is called once per frame
    void Update()
    {
        forwardInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");
        //Forward movement without input
        //transform.Translate(0, 0, 1);
        //transform.Translate(Vector3.forward * Time.deltaTime * speed);

        //Forward movement with input
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);

        //Rotation with input
        transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime * horizontalInput);
    }
}
