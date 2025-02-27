﻿// credits from frog souls
using UnityEngine;
using UnityEngine.SceneManagement;

public class Credits : MonoBehaviour
{
    public void RestartGame()
    {
        Score.CurrentScore = 0;
        ChooseNumLives.numLives = 5;
        Name.username = "Traveller";
        SceneManager.LoadScene("Menu");
    }

    public void Quit()
    {
        Debug.Log("QUIT");
        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
        #endif

        Application.Quit();
    }


}
