using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    int max = 1000;
    int min = 1;
    int guess = 500;
    void Start(){
        

        Debug.Log("Welcome to the number wizard.");
        Debug.Log("Pick a number between...");
        Debug.Log("Highest number: "+max);
        Debug.Log("And Lowest Number: "+min);
        Debug.Log("Is your number higher or lower than:"+guess);
        Debug.Log("Push Up Arrow up for higher, Down Arrow for lower or Enter for Correct Guess:");
        max += 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Debug.Log("Your number is higher... Ok.");
            min = guess;
            guess = (min + max) / 2;
            Debug.Log("Is your number higher or lower than:" + guess);
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Debug.Log("Your number is lower... Ok.");
            max = guess;
            guess = (min + max) / 2;
            Debug.Log("Is your number higher or lower than:" + guess);
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("I knew I could guess it!");
        }
        else if (Input.anyKeyDown)
        {
            Debug.Log("Unknown Command key was pressed.");
        }
    }
}
