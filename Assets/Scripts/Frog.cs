﻿using UnityEngine;
using UnityEngine.SceneManagement;

public class Frog : MonoBehaviour
{

    public Rigidbody2D rb;
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            rb.MovePosition(rb.position + Vector2.right);
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            rb.MovePosition(rb.position + Vector2.left);
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            rb.MovePosition(rb.position + Vector2.up);
            Score.CurrentScore = Score.CurrentScore + 10;
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            rb.MovePosition(rb.position + Vector2.down);
        }

    }

    void OnTriggerEnter2D (Collider2D col)
    {
        if (col.tag == "Car")
        {
            Score.CurrentScore = Score.CurrentScore - 50;
            ChooseNumLives.numLives--;
            FindObjectOfType<GameManager>().EndGame();
        }
    }

}
