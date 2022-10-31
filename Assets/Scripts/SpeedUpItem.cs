using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class SpeedUpItem : MonoBehaviour, IGetItem
{
    [SerializeField]
    private int _point;

    [SerializeField]
    private ItemEffectType _type;

    public void GetItem(Action action)
    {
        CollectItemManager.Instance.AddItem(_point);
        action?.Invoke();
    }

    ItemEffectType IGetItem.GetType()
    {
        return _type;
    }
}
