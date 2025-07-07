using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public int score;
    public UIManager uiManager;

    // Start is called before the first frame update
    void Start()
    {
        uiManager = FindObjectOfType<UIManager>();
        score = 0;
    }

    // Update is called once per frame
    public void addScore()
    {
        score++;
        uiManager.UpdateScore(score);
    }
    public void addScore(int scorePoints)
    {
        score += scorePoints;
        uiManager.UpdateScore(score);
    }
}
