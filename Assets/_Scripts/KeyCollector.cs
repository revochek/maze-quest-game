using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class KeyCollector : MonoBehaviour
{
    private int _collectedKeys;
    private int _totalKeysToCollect;

    public event UnityAction<int, int> KeyCountChanged;
    public event UnityAction AllKeysCollected;

    public void FindTotalCountKeysInScene()
    {
        _totalKeysToCollect = FindObjectsOfType<Key>().Length;
        KeyCountChanged?.Invoke(_collectedKeys, _totalKeysToCollect);
    }

    public void Collect()
    {
        _collectedKeys++;
        KeyCountChanged?.Invoke(_collectedKeys, _totalKeysToCollect);

        if (IsAllKeysCollected())
        {
            AllKeysCollected?.Invoke();
        }
    }

    public bool IsAllKeysCollected() => _collectedKeys == _totalKeysToCollect;
}
