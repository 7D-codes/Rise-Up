using UnityEngine;

public class Player : MonoBehaviour
{
    public int health = 3;

    public void TakeDamage(int damage)
    {
        if (health > 0) health -= damage; else Death();
        Debug.Log(health);
    }

    public void Death()
    {
        Debug.Log("Death");
    }
}
