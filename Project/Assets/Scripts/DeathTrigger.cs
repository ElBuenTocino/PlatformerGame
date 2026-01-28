using System;
using UnityEngine;

public class DeathTrigger : MonoBehaviour 
{
    public static Action OnDeath;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Die();
    }

    private void Die()
    {
        OnDeath?.Invoke();
    }
}