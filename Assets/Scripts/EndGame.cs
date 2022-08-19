using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGame : MonoBehaviour
{
    [SerializeField] GameObject Player;
    Score scoreToSave;

    private void Awake()
    {
        scoreToSave = Player.GetComponent<Score>();
    }

    void Start()
    {
        ConditionUI.OnConditionEnd += Finish;
    }

    void Finish()
    {
        SaveData();
        SceneChanger.instance.DisplayMenu();
    }

    void SaveData()
    {
        PlayerPrefs.SetInt("Score", (int)scoreToSave.ActualScore);
    }
}
