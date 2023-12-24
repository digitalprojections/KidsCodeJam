using System;
using UnityEngine;
public class Collectible : MonoBehaviour
{
    public event Action<Collectible> OnPickup;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        var player = collision.GetComponent<Player>();
        if (player != null)
        {
            OnPickup?.Invoke(this);
            gameObject.SetActive(false);
        }
    }
}