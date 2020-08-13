using System;
using System.Collections;
using System.Collections.Generic;
using Bullets;
using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    [SerializeField] private EnemyHp enemyHp = default;
    
    public Action OnDied { get;set; }
    
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Bullet"))
        {
            var b = other.gameObject.GetComponent<IBullet>();
            int hp = enemyHp.Add(-b.Damage);
            if (hp <= 0)
            {
                Destroy(this.gameObject);
                OnDied?.Invoke();
            }
            Destroy(other.gameObject);
        }
    }
}
