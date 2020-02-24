using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Note: scriptible objects like this onedon't have to be connected to a game object
//State is a ScriptableObject class instead of a Monobehaviour one
//createAssetMenu adds the ability to right and create a 'State' asset from the menu
[CreateAssetMenu(menuName = "State")]
public class State : ScriptableObject
{
    //TextArea defines inspector textbox in unity UI, 10 here is the minimum size of the textfield and 
    //the second number 14 is the minimum number of lines before a scroll bar appears
    [TextArea(10,14)] [SerializeField] string storyText;
    [SerializeField] State[] nextStates;

    public string GetStateStory()
    {
        return storyText;
    }

    public State[] GetNextStates()
    {
        return nextStates;
    }
}
