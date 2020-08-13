using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneController : MonoBehaviour
{
    [SerializeField] private EnemyDamage _enemyDamage;
    [SerializeField] private GameObject _gameClear;
    [SerializeField] private GameObject _gameOver;

    private void Awake()
    {
        _enemyDamage.OnDied += Clear;
    }

    void Clear()
    {
        _gameClear.SetActive(true);
    }
}
