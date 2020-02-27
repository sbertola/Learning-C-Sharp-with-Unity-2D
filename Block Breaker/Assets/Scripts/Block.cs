using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    [SerializeField] AudioClip breakSound;
    [SerializeField] GameObject sparkleVFX;

    //cached reference
    Level level;

    private void Start()
    {
        level = FindObjectOfType<Level>();
        level.CountBreakableBlocks();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        DestryBlock();
        //can use the collision parameter to get additional information from the collision.
    }

    private void DestryBlock()
    {
        PlayDestroySFX();
        Destroy(gameObject);
        level.BlockDestroyed();
        TriggerSparkleVFX();
    }

    private void PlayDestroySFX()
    {
        FindObjectOfType<GameStatus>().AddToScore();
        AudioSource.PlayClipAtPoint(breakSound, Camera.main.transform.position);
    }

    private void TriggerSparkleVFX()
    {
        GameObject sparkles = Instantiate(sparkleVFX, transform.position, transform.rotation);
        Destroy(sparkles, 1f);
    }
}
