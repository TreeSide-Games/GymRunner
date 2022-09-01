using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider))]
public class Item : MonoBehaviour
{
    public EnumItems itemType;
    public float conditionInpact;
    [Range(-1f,1f)] public float speedIncreas;
    public bool isHealthy;
    public bool isMoney;
    public static event Action<Item> OnCollectedItem;

    private void OnTriggerEnter(Collider other)
    {
        OnCollectedItem.Invoke(gameObject.GetComponent<Item>());

        PlayerMovement.instance.Speed += speedIncreas;

        Destroy(gameObject);
    }

    //void goodBehave()
    //{
    //    PlayerMovement.instance.Speed += 1f;
    //}

    //void badBehave()
    //{
    //    PlayerMovement.instance.Speed -= 1f;
    //}
}
