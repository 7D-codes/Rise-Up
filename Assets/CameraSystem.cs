using UnityEngine;

public class CameraSystem : MonoBehaviour
{
    public float speed;
    public float Ypos;

    void Start()
    {
        speed = 1;
    }

    void Update()
    {
        gameObject.transform.Translate(0, -speed * Time.deltaTime, 0);
        Ypos = gameObject.transform.position.y;

        IncreassSpeed();
    }

    void IncreassSpeed()
    {
        if (speed <= 15)
            speed += 0.00025f;
        else
            speed = 15;
    }
}
