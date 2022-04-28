using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreAndMenu : MonoBehaviour
{
    public Text scoreBoard;
    public Canvas win;
    public Canvas playWindow;
    public Button playButton;
    public static int score;
    void Start()
    {
        score = 0;
        win.enabled = false;
        playWindow.enabled = true;
        Time.timeScale = 0;
        playButton.onClick.AddListener(Play);
    }

   
    void Update()
    {
        scoreBoard.text = score.ToString();
        if (score == 6)
        {
            win.enabled = true;
        }
        
    }
    public void UpdateScore()
    {
        score++;
    }
    public int GetScore()
    {
        return score;
    }
    public void Play()
    {
        Time.timeScale = 1;
        playWindow.enabled = false ;

    }
}
