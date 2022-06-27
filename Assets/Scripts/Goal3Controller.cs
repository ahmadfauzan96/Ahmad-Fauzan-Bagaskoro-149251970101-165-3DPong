using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal3Controller : MonoBehaviour
{
    public Collider ball;
    public ScoreManager manager;

    private void OnTriggerEnter(Collider collision)
    {
        if (collision == ball)
        {
            if (manager.scoreP3 < manager.maxScore)
            {
                manager.AddScoreP3(1);
            }
        }
    }
}
