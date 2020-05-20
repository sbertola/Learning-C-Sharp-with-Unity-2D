using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] float movespeed = 10f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    private void Move()
    {
        //GetAxis allows using a variety of keys to get input for the same command, refer to input panel in Edit>Project settings
        var deltaX = Input.GetAxis("Horizontal")*Time.deltaTime*movespeed;
        var deltaY = Input.GetAxis("Vertical") * Time.deltaTime * movespeed;
        var newXPos = transform.position.x + deltaX;
        var newYPos = transform.position.y + deltaY;
        transform.position = new Vector2(newXPos, newYPos); //transform refers to the instance, set new x and y
    }
}
