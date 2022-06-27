using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal1Controller : MonoBehaviour
{
    public Collider ball;
    public ScoreManager manager;

    private void OnTriggerEnter(Collider collision)
    {
        if (collision == ball)
        {
            if (manager.scoreP1 < manager.maxScore)
            {
                manager.AddScoreP1(1);
            }
        }
    }
}
