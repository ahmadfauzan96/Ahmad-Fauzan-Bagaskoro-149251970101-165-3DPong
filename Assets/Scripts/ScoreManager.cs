using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public int scoreP1;
    public int scoreP2;
    public int scoreP3;
    public int scoreP4;
    public int maxScore;

    public int players = 4;

    public BallController ball;
    public GameObject paddle1;
    public GameObject paddle2;
    public GameObject paddle3;
    public GameObject paddle4;
    public GameObject gameOver;

    //tambah skor bagi pemain 1
    //hilangkan paddle setelah pemain mencapai skor maksimum
    public void AddScoreP1(int increment)
    {
        scoreP1 += increment;
        if (scoreP1 <= maxScore)
        {
            ball.ResetBall();
        }
        if (scoreP1 >= maxScore)
        {
            Destroy(paddle1);
            players -= 1;
        }
    }

    //tambah skor bagi pemain 2
    //hilangkan paddle setelah pemain mencapai skor maksimum
    public void AddScoreP2(int increment)
    {
        scoreP2 += increment;
        if (scoreP2 <= maxScore)
        {
            ball.ResetBall();
        }
        if (scoreP2 >= maxScore)
        {
            Destroy(paddle2);
            players -= 1;
        }
    }

    //tambah skor bagi pemain 3
    //hilangkan paddle setelah pemain mencapai skor maksimum
    public void AddScoreP3(int increment)
    {
        scoreP3 += increment;
        if (scoreP3 <= maxScore)
        {
            ball.ResetBall();
        }
        if (scoreP3 >= maxScore)
        {
            Destroy(paddle3);
            players -= 1;
        }
    }

    //tambah skor bagi pemain 4
    //hilangkan paddle setelah pemain mencapai skor maksimum
    public void AddScoreP4(int increment)
    {
        scoreP4 += increment;
        if (scoreP4 <= maxScore)
        {
            ball.ResetBall();
        }
        if (scoreP4 >= maxScore)
        {
            Destroy(paddle4);
            players -= 1;
        }
    }

    //permainan berakhir setelah tersisa satu pemain saja
    private void Update() {
        if (players == 1)
        {
            gameOver.SetActive(true);
        }
    }
}
