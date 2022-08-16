using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider))]
public class Item : MonoBehaviour
{
    public EnumItems itemType;
    public event Action OnCollectedItem;

    private void OnTriggerEnter(Collider other)
    {
        OnCollectedItem.Invoke();
        Destroy(gameObject);
    }
}
