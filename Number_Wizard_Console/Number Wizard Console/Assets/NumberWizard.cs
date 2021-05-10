using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    int max;
    int min;
    int guess;


    // Start is called before the first frame update
    void Start()
    {
        StartGame();
    }

    void StartGame()
    {
        max = 1000;
        min = 1;
        guess = 500; 

        Debug.Log("This is Number Wizard, an interactive guessing game.");
        Debug.Log("Pick any number.");
        Debug.Log("Highest number is: " + max);
        Debug.Log("lowest number is: " + min);
        Debug.Log("Tell me if your number is higher or lower than: " + guess);
        Debug.Log("Push up = higher, Push Down = lower, Push Enter = Correct");
        max = max + 1;
    }
    // Update is called once per frame
    void Update()
    {
        //Detect when the up arrow key is pressed down
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            NextGuess();
        }

        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("Correct!");
            StartGame();
        }
    }
    void NextGuess()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            min = guess;
            guess = (max + min) / 2;
            Debug.Log("Is it higher or lower than..." + guess);
        } 
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = guess;
            guess = (max + min) / 2;
            Debug.Log("Is it higher or lower than..." + guess); 
        }
    }
}
