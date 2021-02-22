using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouse : MonoBehaviour
{
    void Start()
    {
        Cursor.visible=false;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 CursorPos= Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position=CursorPos;
    }
}
