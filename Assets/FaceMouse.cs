using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FaceMouse : MonoBehaviour
{
    // Start is called before the first frame update
    void Update()
    {
        TurntoMouse();
    }

    // Update is called once per frame
    void TurntoMouse()
    {
        Vector3 mousePostion = Input.mousePosition;
        mousePostion = Camera.main.ScreenToWorldPoint(mousePostion);

        Vector2 direction = new Vector2(
            mousePostion.x - transform.position.x,
            mousePostion.y - transform.position.y

        );

        transform.up = direction;
    }
}
