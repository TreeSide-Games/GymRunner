using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    float actualScore;
    float speed;
    public float ActualScore { get { return actualScore; }}

    void Start()
    {
        actualScore = 0;
        speed = GetComponent<PlayerMovement>().Speed;

        GetComponent<PlayerMovement>().OnSpeedChange += UpdateSpeed;

        StartCoroutine(ScoreIncreasCoroutine());
    }

    void UpdateSpeed()
    {
        speed = GetComponent<PlayerMovement>().Speed;
    }

    IEnumerator ScoreIncreasCoroutine()
    {
        while (true)
        {
            actualScore += 1f * speed / 2f;
            ScoreUI.instance.UpdateScoreAmount((int)actualScore);
            yield return new WaitForSeconds(0.5f);
        }
    }
}
