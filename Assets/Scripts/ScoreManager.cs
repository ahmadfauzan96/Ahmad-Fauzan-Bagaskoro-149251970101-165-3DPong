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

    //tambah skor bagi pemain 1
    public void AddScoreP1(int increment)
    {
        scoreP1 += increment;
        if (scoreP1 >= maxScore)
        {
            //hentikan gerakan paddle
            //gawang jadi tembok
        }
    }

    //tambah skor bagi pemain 2
    public void AddScoreP2(int increment)
    {
        scoreP2 += increment;
        if (scoreP2 >= maxScore)
        {
            //hentikan gerakan paddle
            //gawang jadi tembok
        }
    }

    //tambah skor bagi pemain 3
    public void AddScoreP3(int increment)
    {
        scoreP3 += increment;
        if (scoreP3 >= maxScore)
        {
            //hentikan gerakan paddle
            //gawang jadi tembok
        }
    }

    //tambah skor bagi pemain 4
    public void AddScoreP4(int increment)
    {
        scoreP4 += increment;
        if (scoreP4 >= maxScore)
        {
            //hentikan gerakan paddle
            //gawang jadi tembok
        }
    }
}
