using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider))]
public class Item : MonoBehaviour
{
    public EnumItems itemType;
    public bool isHealthy;
    public bool isMoney;
    public static event Action<Item> OnCollectedItem;

    AudioSource collectingAudio;

    private void Awake()
    {
        collectingAudio = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        collectingAudio.Play(0);
        OnCollectedItem.Invoke(gameObject.GetComponent<Item>());

        if (isHealthy)
            goodBehave();
        else
            badBehave();

        Destroy(gameObject);
    }

    void goodBehave()
    {
        PlayerMovement.instance.Speed += 1f;
    }

    void badBehave()
    {
        PlayerMovement.instance.Speed -= 1f;
    }
}
