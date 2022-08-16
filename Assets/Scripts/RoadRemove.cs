using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadRemove : MonoBehaviour
{
    private void OnTriggerExit(Collider other)
    {
        MapGenerator.roads.Remove(gameObject);
        Destroy(gameObject);
    }
}
