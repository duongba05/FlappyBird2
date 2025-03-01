using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    [SerializeField] private GameObject _losePanel;
    [SerializeField] private GameObject _scorePanel;
    [SerializeField] private GameObject pausePanel;
    private bool isPaused = false;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        Time.timeScale = 1.0f;
    }
    public void GameOver()
    {
        _losePanel.SetActive(true);
        _scorePanel.SetActive(false);
        Time.timeScale = 0f;
    }
    public void GameRestart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void PauseGame()
    {
        _losePanel.SetActive(false);
        _scorePanel.SetActive(false);

        isPaused = true;
        Time.timeScale = 0;
        pausePanel.SetActive(true); 
    }

    public void ContinueGame()
    {
        _losePanel.SetActive(false);
        _scorePanel.SetActive(true);

        isPaused = false;
        Time.timeScale = 1; 
        pausePanel.SetActive(false);
    }
    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}