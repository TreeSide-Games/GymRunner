using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapGenerator : MonoBehaviour
{
    [SerializeField] GameObject roadPrefab;

    
    [SerializeField] List<GameObject> roads = new List<GameObject>();

    int maxRoadToPlace = 10;
    int roadDistance = 0;

    void Start()
    {
        for (int i = 0; i < maxRoadToPlace; i++)
        {
            AddRoad();
        }

        StartCoroutine(GeneratorCoroutine());
    }

    private void AddRoad()
    {
        var road = Instantiate(roadPrefab);

        road.transform.position = Vector3.forward * roadDistance;
        road.transform.rotation = Quaternion.identity;

        roads.Add(road);
        roadDistance++;
    }

    IEnumerator GeneratorCoroutine()
    {
        while (true)
        {
            AddRoad();

            if (roads.Count >= maxRoadToPlace)
            {
                RemoveRoad();
            }

            yield return new WaitForSeconds(0.5f);
        }
    }

    private void RemoveRoad()
    {
        Destroy(roads[0]);
        roads.RemoveAt(0);
    }
}
