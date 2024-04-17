using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using static UnityEditor.Progress;

public class StatisticsDisplay : MonoBehaviour
{
    [SerializeField] private TMP_Text _totalKeyText;
    [SerializeField] private TMP_Text _timeText;

    [SerializeField] private Timer _timer;
    [SerializeField] private KeyCollector _keyCollector;

    private void OnEnable()
    {
        _timer.HasBeenUpdated += OnTimeChanged;
        _keyCollector.KeyCountChanged += OnKeyCountChanged;
    }

    private void OnDisable()
    {
        _timer.HasBeenUpdated -= OnTimeChanged;
        _keyCollector.KeyCountChanged -= OnKeyCountChanged;
    }

    public void OnTimeChanged(float time)
    {
        _timeText.text = DisplayTime(time);
    }

    public void OnKeyCountChanged(int curentCount, int totalCount)
    {
        _totalKeyText.text = curentCount + "/" + totalCount;
    }

    private string DisplayTime(float value)
    {
        int minutes = Mathf.FloorToInt(value / 60f);
        int seconds = Mathf.FloorToInt(value % 60f);

        return string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
