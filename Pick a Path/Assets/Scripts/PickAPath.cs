using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickAPath : MonoBehaviour
{
    //SerializeField makes this variable visible within the game object inspector in Unity UI
    //in this case it is used to assign the story text block to this component from the UI
    [SerializeField] Text textComponent;
    [SerializeField] State startingState;

    State state;

    // Start is called before the first frame update
    void Start()
    {
        state = startingState;
        //text within the textbox within the text component
        textComponent.text = state.GetStateStory();
         
        /*   "You suddenly awaken to the sounds of screaming and metal clashing." +
            "'The village must be under attack!' you think to yourself. It's time to act quickly, will you...\n\n" +
            "1.Head towards the back of your house towards the cellar?\n" +
            "2.Head towards the front of your house to get a better view of the situation?\n" +
            "3.Pull the blankets over your head and attempt to fall back to sleep?"*/
    }

    // Update is called once per frame
    void Update()
    {
        ManageState();
    }

    private void ManageState()
    {
        //var is a shortcut for a declared and initialized variable type it automatically knows to assign type State
        var nextStates = state.GetNextStates();

        for(int index = 0; index < nextStates.Length; index++)
        {
            //alpha# represents number keys
            if (Input.GetKeyDown(KeyCode.Alpha1 + index))
            {
                state = nextStates[index];
            }
            else if (Input.GetKeyDown(KeyCode.S))
            {
                Debug.Log("Game will restart here");
            }
            else if (Input.GetKeyDown(KeyCode.Q))
            {
                Debug.Log("Game will end here");
            }
        }
        textComponent.text = state.GetStateStory();
    }
}
