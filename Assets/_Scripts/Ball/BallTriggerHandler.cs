using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BallTriggerHandler : MonoBehaviour
{
    [SerializeField] private KeyCollector _keyCollector;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.TryGetComponent(out Key key))
        {
            _keyCollector.Collect();
            key.Destroy();
        }
    }
}
