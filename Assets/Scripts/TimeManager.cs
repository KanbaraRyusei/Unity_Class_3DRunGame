using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeManager : MonoBehaviour
{
    public static TimeManager Instence { get; private set; }
    public float Timer => _timer;

    public bool IsStopTimer => _isStopTimer;

    public int TimeLimit => _timeLimit;

    [SerializeField]
    private int _timeLimit = 0;

    private float _timer = 0f;

    private float _oldTime = 0f;

    private bool _isStopTimer = true;

    private void Update()
    {
        if (_isStopTimer) return;
        if(_timer > _timeLimit)
        {
            GameManager.GameOver();
        }
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

    public void SetTimeLimit(int limit)
    {
        _timeLimit = limit;
    }

    public void AddTimeLimit(int addTime)
    {
        _timeLimit += addTime;
    }
}
