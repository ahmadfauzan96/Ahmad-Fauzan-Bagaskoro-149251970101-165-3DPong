using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal4Controller : MonoBehaviour
{
    public Collider ball;
    public ScoreManager manager;

    private void OnTriggerEnter(Collider collision)
    {
        if (collision == ball)
        {
            if (manager.scoreP4 < manager.maxScore)
            {
                manager.AddScoreP4(1);
            }
        }
    }
}
