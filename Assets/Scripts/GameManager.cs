using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int leftScore;
    public int rightScore;
    public int maxScore;

    public BallController ball;

    [SerializeField] GameObject pause;

    public void AddRightScore(int increment)
    {
        rightScore += increment;
        ball.ResetBallPosition();

        if (rightScore >= maxScore)
        {
            GameOver();
        }        
    }

    public void AddLeftScore(int increment)
    {
        leftScore += increment;
        ball.ResetBallPosition();

        if (leftScore >= maxScore)
        {
            GameOver();
        }
    }

    public void GameOver()
    {
        SceneManager.LoadScene("Main Menu");
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Time.timeScale = 0;
            pause.SetActive(true);
        }
    }
}
