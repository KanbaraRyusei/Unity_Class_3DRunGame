using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

public class TimePresenter : MonoBehaviour
{
    [SerializeField]
    private TimeView _timeView;

    [SerializeField]
    private SceneLoder _sceneLoder;

    private void Start()
    {
        _timeView.SetMaxValue(TimeManager.Instence.TimeLimit);

        TimeManager.Instence.ObserveEveryValueChanged(t => t.Timer)
            .Subscribe(x => _timeView.ChangeValue(x));

        TimeManager.Instence.ObserveEveryValueChanged(t => t.TimeLimit)
            .Subscribe(x => _timeView.SetMaxValue(x));

        GameManager.OnGameClear += GameClear;
        GameManager.OnGameOver += GameOver;

        TimeManager.Instence.StartTimer();
    }

    private void OnDisable()
    {
        GameManager.OnGameClear -= GameClear;
        GameManager.OnGameOver -= GameOver;
    }

    private void GameClear()
    {
        _sceneLoder.LoadScene("GameClear");
    }

    private void GameOver()
    {
        _sceneLoder.LoadScene("GameOver");
    }
}
