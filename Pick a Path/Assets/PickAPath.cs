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
        textComponent.text = "Here the story begins...";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
