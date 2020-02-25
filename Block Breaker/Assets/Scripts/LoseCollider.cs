using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseCollider : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //hard coded string reference not always ideal but ok in this case since known name not gonna change.
        SceneManager.LoadScene("Game Over");
    }
}
