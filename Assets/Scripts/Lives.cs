﻿using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Lives : MonoBehaviour
{

    public Text livesText;
    public GameManager gameManager;

    void Start()
    {
        
        if (ChooseNumLives.numLives < 1)
        {
            Debug.Log("GAME OVER");
            Debug.Log("Loading menu...");
            ChooseNumLives.numLives = 5;
            Score.CurrentScore = 0;
            Name.username = "Traveller";
            SceneManager.LoadScene("Menu");
        }
        livesText.text = "Lives: " + ChooseNumLives.numLives.ToString(); 

    }

}
