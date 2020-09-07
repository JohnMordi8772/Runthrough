/** John Mordi* 
 * Assignment #2 Challenge #1 * 
 * manages the conditions for wins/losses and adjusts textbox repectively*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    public static int score;
    public static bool gameover;
    public static bool won;
    //attach in inspector
    public Text textbox;


    // Start is called before the first frame update
    void Start()
    {
        //initialize values when scene is loaded or reloaded
        score = 0;
        gameover = false;
        won = false;
    }

    // Update is called once per frame
    void Update()
    {
        //Score displays during game
        if(!gameover)
        {
            textbox.text = "Score: " + score;
        }
        //adjusts win conditions
        if(score>=5)
        {
            gameover = true;
            won = true;
        }
        //displays game results and gives the option of playing again
        if (gameover)
        {
            if (won)
            {
                textbox.text = "You win!\nPress R to play again.";
            }
            else
            {
                textbox.text = "You lose.\nPress R to try again.";
            }
            if (Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
    }
}
