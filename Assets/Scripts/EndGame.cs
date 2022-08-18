using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGame : MonoBehaviour
{
    [SerializeField] GameObject Player;

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
        PlayerPrefs.SetInt("Score", (int)Player.GetComponent<Score>().ActualScore);
    }
}
