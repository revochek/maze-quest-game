using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    [SerializeField] private GameObject _pickupFxPrefab;

    public void Destroy()
    {
        PlayPickupFxPrefab();
        Destroy(gameObject);
    }

    private void PlayPickupFxPrefab()
    {
        Instantiate(_pickupFxPrefab, transform.position, Quaternion.Euler(-90,0,0));
    }
}
