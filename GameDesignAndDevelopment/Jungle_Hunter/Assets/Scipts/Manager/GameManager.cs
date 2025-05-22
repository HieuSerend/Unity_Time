using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject gameOverPanel;

    public void GameOver()
    {
        Time.timeScale = 0f; // Dừng game
        gameOverPanel.SetActive(true);
    }
}
