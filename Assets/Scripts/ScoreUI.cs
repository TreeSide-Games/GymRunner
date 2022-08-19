using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreUI : MonoBehaviour
{
    #region Singleton

    public static ScoreUI instance;

    private void Awake()
    {
        if (instance == null)
            instance = this;
    }

    #endregion

    [SerializeField] Text ScoreAmount;

    private void Start()
    {
        ScoreAmount.text = "0";
    }

    public void UpdateScoreAmount(int score)
    {
        ScoreAmount.text = score.ToString();
    }
}
