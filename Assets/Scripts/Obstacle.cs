using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public bool randomRotation;
    public float prefPositionY;

    [SerializeField] float slowDownSpeed = 1f;

    void Start()
    {
        transform.localPosition += Vector3.up * prefPositionY;

        
    }

    private void OnTriggerEnter(Collider other)
    {
        StartCoroutine(SlowDownCoroutine());
    }

    IEnumerator SlowDownCoroutine()
    {
        PlayerMovement.instance.Speed -= slowDownSpeed;

        yield return new WaitForSeconds(1f);

        PlayerMovement.instance.Speed += slowDownSpeed;
        Destroy(gameObject);
    }
}
