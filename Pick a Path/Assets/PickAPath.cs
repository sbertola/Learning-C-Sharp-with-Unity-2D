using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickAPath : MonoBehaviour
{
    //SerializeField makes this variable visible within the game object inspector in Unity UI
    //in this case it is used to assign the story text block to this component from the UI
    [SerializeField] Text textComponent;


    // Start is called before the first frame update
    void Start()
    {
        //text within the textbox within the text component
        textComponent.text = "You suddenly awaken to the sounds of screaming and metal clashing." +
            "'The village must be under attack!' you think to yourself. It's time to act quickly, will you...\n\n" +
            "1.Head towards the back of your house towards the cellar?\n" +
            "2.Head towards the front of your house to get a better view of the situation?\n" +
            "3.Pull the blankets over your head and attempt to fall back to sleep?";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
