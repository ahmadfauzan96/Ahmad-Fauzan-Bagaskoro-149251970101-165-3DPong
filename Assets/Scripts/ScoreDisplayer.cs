using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreDisplayer : MonoBehaviour
{
    public Text skor1;
    public Text skor2;
    public Text skor3;
    public Text skor4;

    public ScoreManager manager;

    private void Update()
    {
        skor1.text = manager.scoreP1.ToString();
        skor2.text = manager.scoreP2.ToString();
        skor3.text = manager.scoreP3.ToString();
        skor4.text = manager.scoreP4.ToString();
    }
}
