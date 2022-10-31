using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Item : MonoBehaviour, IGetItem
{
    [SerializeField]
    private int _point = 1;

    [SerializeField]
    private ItemEffectType _type;

    public void GetItem(Action action)
    {
        CollectItemManager.Instance.AddItem(_point);
        action?.Invoke();
        Destroy(gameObject);
    }

    ItemEffectType IGetItem.GetType()
    {
        return _type;
    }
}
