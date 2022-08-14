using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapGenerator : MonoBehaviour
{
    [SerializeField] GameObject roadPrefab;
    [SerializeField] List<GameObject> itemPrefab = new List<GameObject>();

    
    List<GameObject> roads = new List<GameObject>();

    [SerializeField] int maxRoadToPlace = 10;

    int roadDistance = 0;

    void Start()
    {
        for (int i = 0; i < maxRoadToPlace - 2; i++)
        {
            AddRoad();
        }

        StartCoroutine(GeneratorCoroutine());
    }

    private void AddRoad()
    {
        ChooseItem();
        var road = Instantiate(roadPrefab);

        road.transform.position = Vector3.forward * roadDistance * 3;
        road.transform.rotation = Quaternion.Euler(0f, 90f, -180f);
        road.GetComponent<RoadRemove>().OnRoadDestroyed += RemoveRoad;

        roads.Add(road);
        roadDistance++;

        PlaceItemOn(road.transform);
    }

    private GameObject ChooseItem()
    {
        int random = UnityEngine.Random.Range(0, System.Enum.GetValues(typeof(EnumItems)).Length);

        EnumItems itemType = (EnumItems)random;

        return itemPrefab.Find(e => e.GetComponent<Item>().itemType == itemType);
        
    }

    private void PlaceItemOn(Transform road)
    {
        var itemToInstantiate = ChooseItem();
        if (itemToInstantiate == null)
            return;

        var item = Instantiate(itemToInstantiate);
        item.transform.parent = road.transform;

        //item.transform.localPosition = Vector3.forward + Vector3.up * -3f;

        item.transform.localPosition = Vector3.right + Vector3.up * -3f;
        //item.transform.localRotation = Quaternion.identity;

        var randomnes = UnityEngine.Random.Range(0f,1f);

        
        //if (randomnes < 0.3f)
        //    item.transform.localPosition += Vector3.right * 0.3f;
        //else if (randomnes > 0.6f)
        //    item.transform.localPosition += Vector3.left * 0.3f;

        if (randomnes < 0.3f)
            item.transform.localPosition += Vector3.forward * 3f / 10f;
        else if (randomnes > 0.6f)
            item.transform.localPosition += Vector3.back * 3f / 10f;

    }

    IEnumerator GeneratorCoroutine()
    {
        while (true)
        {
            if (roads.Count < maxRoadToPlace)
            {
                AddRoad();
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
