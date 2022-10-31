using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public interface IGetItem
{
    void GetItem(Action action);
    ItemEffectType GetType();
}

public enum ItemEffectType
{
    SpeedUp,
    AddTime
}
