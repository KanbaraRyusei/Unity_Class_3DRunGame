using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

public class TimePresenter : MonoBehaviour
{
    [SerializeField]
    private TimeView _timeView;

    private void Start()
    {
        _timeView.SetMaxValue(TimeManager.Instence.TimeLimit);

        TimeManager.Instence.ObserveEveryValueChanged(t => t.Timer)
            .Subscribe(x => _timeView.ChangeValue(x));

        TimeManager.Instence.ObserveEveryValueChanged(t => t.TimeLimit)
            .Subscribe(x => _timeView.SetMaxValue(x));

        TimeManager.Instence.StartTimer();
    }
}
