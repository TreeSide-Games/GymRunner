using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public bool randomRotation;

    [SerializeField] float slowDownSpeed = 1f;

    void Start()
    {
        if (randomRotation)
        {
            transform.localRotation *= Quaternion.Euler(Vector3.up * UnityEngine.Random.rotation.y);
        }
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
