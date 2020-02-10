using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    // Start is called before the first frame update
    void Start(){
        int max = 1000;
        int min = 1;

        Debug.Log("Welcome to the number wizard.");
        Debug.Log("Pick a number between...");
        Debug.Log("Highest number: "+max);
        Debug.Log("And Lowest Number: "+min);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
