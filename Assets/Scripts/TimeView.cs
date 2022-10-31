using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeView : MonoBehaviour
{
    [SerializeField]
    Slider _slider;

    public void SetMaxValue(int value)
    {
        _slider.maxValue = value;
    }

    public void ChangeValue(float value)
    {
        _slider.value = _slider.maxValue - value;
    }
}
