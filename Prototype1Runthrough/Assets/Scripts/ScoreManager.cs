/** John Mordi* 
 * Assignment #2 Prototype #1* 
 * manages the conditions for wins/losses and adjusts textbox repectively*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//allows us to work with the scene manager to load or reload scenes
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    //notice public static variables can be accessed by any script
    //but cannotbe seen in the inspector
    public static bool gameover;
    public static bool won;
    public static int score;

    //set in inspector
    public Text textbox;

    //initializes values when scene is loaded
    public void Start()
    {
        gameover = false;
        won = false;
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(!gameover)
        {
            textbox.text = "Score:" + score;
        }

        if (score >= 3)
        {
            won = true;
            gameover = true;
        }

        if(gameover)
        {
            if(won)
            {
                textbox.text = "You win!\nPress R to play again.";
            }
            else
            {
                textbox.text = "You lose.\nPress R to try again.";
            }
            if(Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
    }
}
