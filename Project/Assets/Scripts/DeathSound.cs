using UnityEngine;

public class DeathSound : MonoBehaviour
{
    public AudioClip DeathSFX;
    void Start()
    {
        AudioManager.Instance.Play(DeathSFX);
    }

  
}
