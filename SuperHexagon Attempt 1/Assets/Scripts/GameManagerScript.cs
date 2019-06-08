using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManagerScript : MonoBehaviour
{
    public GameObject panelUI;
    public TextMeshProUGUI scoreText;
    private int score;
    private int timer;

    private void Start()
    {
        panelUI.SetActive(false);
        score = 0;
        scoreText.text = "SCORE: " + score;
        timer = 0;
    }

    private void Update()
    {
        timer++;
        CanvasElement();
        if (panelUI.activeInHierarchy == false)
        {
            UpdateScore();
        }
         //UpdateScore();
    }

    public void UpdateScore()
    {
        if (timer >= 100)
        {
            score += 10;
            scoreText.text = "SCORE: " + score.ToString();
            timer = 0;
        }
    }

    public void CanvasElement()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            panelUI.SetActive(true);
            Time.timeScale = 0;
        }
    }

    public void UnpauseGame()
    {
        Time.timeScale = 1;
        panelUI.SetActive(false);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("Main Menu");
        Time.timeScale = 1;
    }
}
