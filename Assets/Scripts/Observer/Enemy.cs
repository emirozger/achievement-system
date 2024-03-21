using UnityEngine;

public class Enemy : MonoBehaviour, IDamageObserver
{
    public float health = 100f;

    public void OnDamageTaken(float damage)
    {
        health -= damage;
        Debug.Log("Enemy health: " + health);
    }
}
public interface IDamageObserver
{
    void OnDamageTaken(float damage);
}