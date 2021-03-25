using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorControls : MonoBehaviour
{
    private float HorizontalInputValue;
    private float VerticalInputValue;

    private void Update()
    {
        HorizontalInputValue = Input.GetAxis("Horizontal");
        VerticalInputValue = Input.GetAxis("Vertical");
    }

    private void FixedUpdate()
    {
        Move();
    }

    private void Move()
    {
        
    }
}
