﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UiManager : MonoBehaviour
{
    public TextMeshProUGUI txtScore;
    public TextMeshProUGUI txtHealthPoints;
    
    void Start()
    {
        txtScore.text = "0";
    }
    public void UpdateScore(int score)
    {
        txtScore.text = score.ToString();
    }

    public void UpdateHealth(int health)
    {
        txtHealthPoints.text = health.ToString();
    }


}
