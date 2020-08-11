using System;
using System.Collections;
using System.Collections.Generic;
using Guns;
using UnityEngine;

public class PlayerShot : MonoBehaviour
{
    [SerializeField] private Transform emitterTransform = default;
    [SerializeField] private GameObject normalGun;
    
    void Start()
    {
        normalGun = Instantiate(normalGun, this.gameObject.transform);
        normalGun.GetComponent<NormalGun>().EmitterTransform = emitterTransform;
    }

    void Update()
    {
        
    }
}