using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Timer : MonoBehaviour
{
    private float _currentTime;
    private bool _isRunning = true;

    public event UnityAction<float> HasBeenUpdated;

    private void Update()
    {
        if (!_isRunning) return;

        _currentTime += Time.deltaTime;
        HasBeenUpdated?.Invoke(_currentTime);
    }

    private void StopTimer()
    {
        _isRunning = false;
    }
}

