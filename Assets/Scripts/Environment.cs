using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Environment : MonoBehaviour
{
    public float prefPositionX;
    public float prefPositionY;
    public bool isInvertedRotationZ;


    private void OnTriggerExit(Collider other)
    {
        Destroy(gameObject);
    }
}
