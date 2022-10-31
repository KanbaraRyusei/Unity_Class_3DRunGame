using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public static class GameManager
{
    public static bool IsGameClear { get; private set; } = false;
    public static bool IsGameOver { get; private set; } = false;

    public static Action OnGameStart;
    public static Action OnGameClear;
    public static Action OnGameOver;

    public static void GameStart()
    {
        IsGameClear = false;
        IsGameOver = false;
        OnGameStart?.Invoke();
        Debug.Log("GameStart");
    }

    public static void GameClear()
    {
        IsGameClear = true;
        IsGameOver = false;
        OnGameClear?.Invoke();
        Debug.Log("GameClear");

    }

    public static void GameOver()
    {
        IsGameClear = false;
        IsGameOver = true;
        OnGameOver?.Invoke();
        Debug.Log("GameOver");
    }
}
