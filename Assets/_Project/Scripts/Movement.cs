using UnityEngine;

public class Movement : MonoBehaviour
{
    Vector2 mousePosition;

    void FixedUpdate()
    {
        mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = mousePosition;
    }
}
