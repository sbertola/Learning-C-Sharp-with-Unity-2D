using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    //configuration parameters
    [SerializeField] float screenWidthUnits = 16f;
    [SerializeField] float minBound = 1f;
    [SerializeField] float maxBound = 15f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //mouse position gives current position of mouse, .x asks specifically for x coordinate
        // dividing by screen width gives postion as a % of the screen
        // Multiply by 16 to account for camera size in unity units

        float mousePos = Input.mousePosition.x / Screen.width * screenWidthUnits;

        //vector2 stores x,y components
        Vector2 paddlePos = new Vector2(transform.position.x, transform.position.y);

        //mathf.clamp sets min and max limits on a value
        paddlePos.x = Mathf.Clamp(mousePos, minBound, maxBound);
        transform.position = paddlePos;
    }
}
