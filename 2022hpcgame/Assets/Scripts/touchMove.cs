using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class touchMove : MonoBehaviour
{
    private Touch touch;
    private float speedModifier;
    void Start()
    {
        speedModifier = 0.01f;
    }
    void Update()
    {
        if (Input.touchCount > 0)
        {
            touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Began)
            {
                transform.position = new Vector3(transform.position.x + touch.deltaPosition.x * 0.1f, transform.position.y, transform.position.z + touch.deltaPosition.y * 0.1f);
            }
        }
    }
}
