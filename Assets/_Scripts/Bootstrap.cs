using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bootstrap : MonoBehaviour
{
    [SerializeField] private KeyCollector _keyCollector;

    private void Awake()
    {
        _keyCollector.FindTotalCountKeysInScene();
    }
}
