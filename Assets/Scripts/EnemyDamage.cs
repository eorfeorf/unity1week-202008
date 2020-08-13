using System;
using System.Collections;
using System.Collections.Generic;
using Bullets;
using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    [SerializeField] private EnemyHp enemyHp = default;
    
    public Action OnDied { get;set; }
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Bullet"))
        {
            // HP減少
            var b = other.transform.root.GetComponent<IBullet>();
            int hp = enemyHp.Add(-b.Damage);
            if (hp <= 0)
            {
                Destroy(this.gameObject);
                OnDied?.Invoke();
            }
            
            // 弾の削除
            Destroy(other.transform.root.gameObject);
        }
    }
}
