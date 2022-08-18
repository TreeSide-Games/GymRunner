using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    float score;
    float speed;

    void Start()
    {
        score = 0;
        speed = GetComponent<PlayerMovement>().speed;

        StartCoroutine(ScoreIncreasCoroutine());
    }

    IEnumerator ScoreIncreasCoroutine()
    {
        while (true)
        {
            score += 1f * speed / 2f;
            ScoreUI.instance.UpdateScoreAmount((int)score);
            yield return new WaitForSeconds(0.5f);
        }
    }
}
