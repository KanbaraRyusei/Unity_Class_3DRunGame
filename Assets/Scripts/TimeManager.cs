using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeManager : MonoBehaviour
{
    public TimeManager Instance { get; private set; }

    public float Timer => _timer;

    private float _timer = 0f;

    private float _oldTime = 0f;

    private bool _isStopTimer = true;

    private void Update()
    {
        if (_isStopTimer) return;
        _timer += Time.deltaTime;
    }

    public void StartTimer()
    {
        _isStopTimer = false;
        _timer = 0f;
    }

    public void StopTimer()
    {
        _isStopTimer = true;
        _oldTime = _timer;
    }

    public void RestartTimer()
    {
        _isStopTimer = false;
        _timer = _oldTime;
    }

    public void ResetTimer()
    {
        _isStopTimer = true;
        _timer = 0f;
        _oldTime = 0f;
    }
}
