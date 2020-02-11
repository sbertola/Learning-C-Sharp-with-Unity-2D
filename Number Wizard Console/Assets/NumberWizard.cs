using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    int max = 1000;
    int min = 1;
    int guess = 500;
    void Start()
    {
        StartGame();
    }

    void StartGame()
    {
        max = 1000;
        min = 1;
        guess = 500;

        Debug.Log("Welcome to the number wizard.");
        Debug.Log("Pick a number between...");
        Debug.Log("Highest number: " + max);
        Debug.Log("And Lowest Number: " + min);
        Debug.Log("Is your number higher or lower than:" + guess);
        Debug.Log("Up Arrow = higher, Down Arrow = lower , Enter = Correct Guess.");
        max += 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Debug.Log("Your number is higher... Ok.");
            min = guess;
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Debug.Log("Your number is lower... Ok.");
            max = guess;
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("I knew I could guess it!");
            StartGame();
        }
        else if (Input.anyKeyDown)
        {
            Debug.Log("Unknown Command key was pressed.");
        }
    }

    void NextGuess()
    {
        guess = (min + max) / 2;
        Debug.Log("Is your number higher or lower than:" + guess);
    }
}
