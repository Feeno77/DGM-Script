using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Brick : MonoBehaviour {

    public int health;
    public Sprite[] sprites;

    private void Awake()
    {
        GameManager.brickCount++;
        GetComponent<SpriteRenderer>().sprite = sprites[health];
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        health--;
        GetComponent<SpriteRenderer>().sprite = sprites[health];
        
        if (health <= 0)
        {
            Destroy(gameObject);
            GameManager.brickCount--;
            if(GameManager.brickCount == 0)
            {
                FindObjectOfType<GameManager>().LoadNextLevel();
            }
        }
            
    }
}
