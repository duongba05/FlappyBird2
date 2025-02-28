using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private TextMeshProUGUI _currentScore;
    [SerializeField] private TextMeshProUGUI _highScore;
    private int score;

    public static ScoreManager instance;
    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
    }
    void Start()
    {
        _currentScore.text = score.ToString();
        _highScore.text = PlayerPrefs.GetInt("highscore",0).ToString();
        RefreshHighScore();
    }

    private void RefreshHighScore()
    {
        if(score > PlayerPrefs.GetInt("highscore"))
        {
            PlayerPrefs.SetInt("highscore", score);
            _highScore.text = score.ToString();
        }
    }
    public void RefreshScore()
    {
        score++;
        _currentScore.text = score.ToString() ;
        RefreshHighScore() ;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
