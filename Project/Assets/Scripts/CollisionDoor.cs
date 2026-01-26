using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using System;
using UnityEngine.SceneManagement;


public class Door : MonoBehaviour
{
    public static Action<Door> OnDoorCollision;
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        OnDoorCollision?.Invoke(this);
    }
}
