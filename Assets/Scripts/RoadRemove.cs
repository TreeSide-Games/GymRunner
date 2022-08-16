using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadRemove : MonoBehaviour
{
    public event Action OnRoadDestroyed;

    private void OnTriggerExit(Collider other)
    {
        OnRoadDestroyed.Invoke();
        Destroy(gameObject);
    }
}
