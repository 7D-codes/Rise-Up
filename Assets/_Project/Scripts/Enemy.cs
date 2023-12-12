using UnityEngine;

public class Enemy : MonoBehaviour
{
    void Start()
    {
        Collider2D collider2D = GetComponent<Collider2D>();

        if (collider2D != null)
            collider2D.isTrigger = true;        
        else 
            Debug.LogError("No Collider2D found on " + gameObject.name);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        other.GetComponent<Player>().TakeDamage(1);
    }
}
