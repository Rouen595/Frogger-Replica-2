// change speed from frogger
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeSpeed : MonoBehaviour
{
    public static float minSpd = 8f;
    public static float maxSpd = 12f;
  
    public float gameSpeed;

    public void Change(float f)
    {
        GetComponent<Text>().text = f.ToString();
        gameSpeed = f;

        if (gameSpeed < 4f)
        {
            minSpd = 6f;
            maxSpd = 10f;
        }

        else if (gameSpeed >= 4f && gameSpeed < 8f) 
        {
            minSpd = 8f;
            maxSpd = 12f;
        }

        else if (gameSpeed >= 8f)
        {
            minSpd = 10f;
            maxSpd = 14f;
        }
    }
}
