using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneController: MonoBehaviour
{
    [SerializeField] private GameObject _gameClear = default;
    [SerializeField] private GameObject _gameOver = default;

    public void Clear()
    {
        _gameClear.SetActive(true);
    }

    public void GameOver()
    {
        _gameOver.SetActive(true);
    }
}
