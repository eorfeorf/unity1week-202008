using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHp : MonoBehaviour
{
    [SerializeField] private int maxHp = default;

    private int _hp;

    private void Awake()
    {
        _hp = maxHp;
    }

    void Start()
    {
        _hp = maxHp;
    }

    public int Add(int value)
    {
        _hp += value;
        if (_hp < 0)
        {
            _hp = 0;
        }
        Debug.Log(_hp);

        return _hp;
    }
}