using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class ThrowStar : MonoBehaviour
{ 
    float posY;
    float moveSpeed;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            posY = Input.mousePosition.y;
        }
        if (Input.GetMouseButtonUp(0))
        {
            float currentY = Input.mousePosition.y;
            float diff = currentY - posY;
            
            if(diff > 0f) moveSpeed = diff;

        }

        transform.Rotate(0, 0, -moveSpeed * 0.1f);
        transform.Translate(0, moveSpeed * 0.001f, 0, Space.World);
    }
}