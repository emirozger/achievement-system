using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    public float currentHealth = 100f;

    public void TakeDamage(float damage)
    {
        currentHealth -= damage;
        Debug.Log("Player health: " + currentHealth);
        NotifyObservers(damage);
        //asdas
    }

    private void NotifyObservers(float damage)
    {
        IDamageObserver[] observers = GetComponents<IDamageObserver>();

        foreach (var observer in observers)
        {
            observer.OnDamageTaken(damage);
        }
    }
}
