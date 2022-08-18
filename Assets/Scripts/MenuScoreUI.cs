using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuScoreUI : MonoBehaviour
{
    [SerializeField] Text actualScoreText;
    [SerializeField] Text recordScoreText;

    int score;
    int record;

    void Start()
    {
        CheckIfNewRecord();
        DisplayScores();
    }

    private void CheckIfNewRecord()
    {
        score = PlayerPrefs.GetInt("Score");
        record = PlayerPrefs.GetInt("Record");

        if (score > record)
        {
            DisplayNewRecord();
            PlayerPrefs.SetInt("Record", score);
        }
    }

    private void DisplayScores()
    {
        actualScoreText.text = score.ToString();
        recordScoreText.text = record.ToString();
    }

    private void DisplayNewRecord()
    {

    }
}
