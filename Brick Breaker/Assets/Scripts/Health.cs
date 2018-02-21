using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour {

    public int health;

    private void Awake()
    {
        GameManager.brickCount++;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        health--;
        
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
