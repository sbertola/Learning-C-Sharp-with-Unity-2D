using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NumberWizard : MonoBehaviour
{
    [SerializeField] int max = 1000;
    [SerializeField] int min = 1;
    [SerializeField] TextMeshProUGUI guessText;
    int guess = 500;
    void Start()
    {
        StartGame();
    }

    void StartGame()
    {
        NextGuess();
    }

    public void GuessHigher()
    {
        min = guess +1;
        NextGuess();
    }

    public void GuessLower()
    {
        max = guess+1;
        NextGuess();
    }

    void NextGuess()
    {
        guess = Random.Range(min,max+1);
        guessText.text = guess.ToString();
    }
}
