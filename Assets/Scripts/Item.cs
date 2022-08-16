using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider))]
public class Item : MonoBehaviour
{
    public EnumItems itemType;
    public bool isHealthy;
    //public event Action OnCollectedItem;

    private void OnTriggerEnter(Collider other)
    {
        if (isHealthy)
            goodBehave();
        else
            badBehave();

        Destroy(gameObject);
    }

    void goodBehave()
    {

    }

    void badBehave()
    {

    }
}
