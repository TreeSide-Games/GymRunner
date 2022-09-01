using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    #region Singleton

    public static PlayerMovement instance;
    private void Awake()
    {
        if(instance == null)
            instance = this;
    }

    #endregion

    public event Action OnSpeedChange;
    [SerializeField] private float speed = 2f;
    [SerializeField] private Joystick joystick;
    //private RectTransform joystickReckTransform;
    //private Vector2 joystickNewPosition;

    public float Speed 
    {
        get { return speed; } 
        set
        {
            speed = Mathf.Clamp(value,0.1f,12f);
            OnSpeedChange.Invoke();
        }
    }

    void Start()
    {
        //joystickReckTransform = joystick.GetComponent<RectTransform>();
    }

    
    void Update()
    {

        //transform.position += Vector3.forward * speed * Time.deltaTime;
        //transform.position += Vector3.right * Input.GetAxis("Horizontal") * speed / 100f;


        //float horizontalMoveValue = Mathf.Clamp(1 * Input.mousePosition.normalized.x * speed * Time.deltaTime, -0.45f, 0.45f);

        //transform.position = new Vector3(horizontalMoveValue, transform.position.y);



        //transform.position += Vector3.forward * speed * Time.deltaTime;
        //float horizontalMoveValue2 = Input.mousePosition.normalized.x;
        //transform.position += Vector3.right * horizontalMoveValue2 * speed / 100f;
        //float move = Input.GetAxis("Horizontal");
        //Debug.Log("Axis: " + move);
        //Debug.Log("Mouse: " + horizontalMoveValue2);
        
        transform.position += Vector3.forward * speed * Time.deltaTime;

        //if (joystickReckTransform.localScale.x == 0)
        //{
        //    if (Input.touchCount != 0)
        //    {
        //        Touch touch = Input.GetTouch(0);

        //        RectTransformUtility.ScreenPointToLocalPointInRectangle(joystickReckTransform, touch.position, null, out joystickNewPosition);

        //        joystickReckTransform.localScale = Vector3.one;
        //        joystickReckTransform.localPosition = joystickNewPosition;
        //    }
        //}
        //else
        //{
        //    if (Input.touchCount == 0)
        //    {
        //        joystickReckTransform.localScale = Vector3.zero;
        //        return;
        //    }
        //}

        


        //if(Input.touchCount > 0)
        //{
        //    Touch touch = Input.GetTouch(0);
        //    var touchPosition = Camera.main.ScreenToWorldPoint(touch.position);
        //    touchPosition.z = 0f;



        //    joystick.gameObject.SetActive(true);
        //    joystick.GetComponent<Transform>().localPosition = touchPosition;

        //}
        //else
        //{
        //    joystick.gameObject.SetActive(false);
        //    return;
        //}

        //transform.position += Vector3.right * joystick.Horizontal * speed * Time.deltaTime;
        float horizontalMoveValue = Mathf.Clamp(transform.position.x + 1 * joystick.Horizontal * 1.5f * Time.deltaTime, -0.45f, 0.45f);

        transform.position = new Vector3(horizontalMoveValue, transform.position.y, transform.position.z);
    }                                                                             
}
