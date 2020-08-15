using System;
using System.Collections;
using System.Collections.Generic;
using Guns;
using UnityEngine;
using Weapons;

public class PlayerShot : MonoBehaviour
{
    [SerializeField] private Transform emitterTransform = default;
    [SerializeField] private GameObject[] guns;
    
    void Start()
    {
        foreach (var gun in guns)
        {
            SetupGun(gun);
        }
    }

    void Update()
    {
        
    }

    private void SetupGun(GameObject gunPrefab)
    {
        var gun = Instantiate(gunPrefab, this.gameObject.transform).GetComponent<IGun>();
        gun.EmitterTransform = emitterTransform;
    }
}