using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

[RequireComponent(typeof(BoxCollider))]
public class Door : MonoBehaviour
{
    [SerializeField] private GameObject _cross;
    [SerializeField] private KeyCollector _keyCollectionData;
    [SerializeField] private GameObject _confettiFxPrefab;

    private BoxCollider _collider;

    private void OnEnable()
    {
        _keyCollectionData.AllKeysCollected += OnAllKeysCollected;
    }

    private void OnDisable()
    {
        _keyCollectionData.AllKeysCollected -= OnAllKeysCollected;
    }

    private void Start()
    {
        _collider = GetComponent<BoxCollider>();

        _collider.enabled = false;
        _cross.SetActive(true);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.TryGetComponent(out Ball ball))
        {
            PlayConfettiFxPrefab();
            Time.timeScale = 0;
        }
    }

    public void OnAllKeysCollected()
    {
        _collider.enabled = true;
        _cross.SetActive(false);
    }

    private void PlayConfettiFxPrefab()
    {
        Instantiate(_confettiFxPrefab, new Vector3(0,2,1), Quaternion.Euler(-90, 0, 0));
    }
}
