using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBySwipe : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        Touch touch = Input.GetTouch(0);
        Vector3 touchPosition = Camera.main.ScreenToWorldPoint(touch.position);
        touchPosition.z = 0f;
        transform.position = touchPosition;
    }
}
