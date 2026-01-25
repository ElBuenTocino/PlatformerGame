using System;
using UnityEngine;

public class Coin : MonoBehaviour {
    public int Value = 5;

    public static Action<Coin> OnCoinCollected;

    public AudioClip CoinSFX;

    private void OnTriggerEnter2D(Collider2D other)
    {
        OnCoinCollected?.Invoke(this);

        AudioManager.Instance.Play(CoinSFX);

        Destroy(gameObject);
    }
}
