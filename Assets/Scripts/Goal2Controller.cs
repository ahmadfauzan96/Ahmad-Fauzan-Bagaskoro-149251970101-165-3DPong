using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal2Controller : MonoBehaviour
{
    public Collider ball;
    public ScoreManager manager;

    private void OnTriggerEnter(Collider collision)
    {
        if (collision == ball)
        {
            if (manager.scoreP2 < manager.maxScore)
            {
                manager.AddScoreP2(1);
            }
        }
    }
}
