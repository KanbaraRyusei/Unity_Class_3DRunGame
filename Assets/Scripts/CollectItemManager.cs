using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectItemManager : MonoBehaviour
{
    public static CollectItemManager Instance { get; private set; }

    public int ItemCount => _itemCount;

    [SerializeField]
    private int _needItemNum = 10;

    private int _itemCount = 0;

    private void Awake()
    {
        Instance = this;
    }

    public void AddItem(int count)
    {
        _itemCount += count;
        if(IsCollectItem())
        {
            GameManager.GameClear();
        }
    }

    public void ResetItem()
    {
        _itemCount = 0;
    }

    private bool IsCollectItem()
    {
        if (_itemCount >= _needItemNum)
        {
            return true;
        }
        return false;
    }
}
