using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameHelpManager : MonoBehaviour
{

    public static bool GameIsOver;
    
    public GameObject gameOverUI;

    private void Start()
    {
        GameIsOver = false;
    }

    void Update()
    {
        if (GameIsOver) 
            return;

        if (Input.GetKeyDown("e"))
        {
            EndGame();
        }
        
        if (PlayerStats.Lives <= 0)
        {
            EndGame();
        }
    }

    void EndGame()
    {
        GameIsOver = true;
        gameOverUI.SetActive(true);
    }
}
