using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float speed;

    void Start()
    {
        
    }

    
    void Update()
    {
        transform.position += Vector3.forward * speed * Time.deltaTime;

        transform.position += Vector3.right * Input.GetAxis("Horizontal") * speed / 100f;
        //float horizontalMoveValue = Mathf.Clamp(1 * Input.mousePosition.normalized.x * speed * Time.deltaTime, -0.45f, 0.45f);

        //transform.position = new Vector3(horizontalMoveValue, transform.position.y);

    }                                                                             
}
