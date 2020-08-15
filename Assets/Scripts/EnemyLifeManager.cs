using System;
using System.Collections;
using System.Collections.Generic;
using Bullets;
using UnityEngine;
using UnityEngine.Events;

public class EnemyLifeManager : MonoBehaviour
{
    [SerializeField] private EnemyHp enemyHp = default;
    [SerializeField] private UnityEvent onDied;
    [SerializeField] private UnityEvent onDamage;
    
    public UnityEvent OnDied => onDied;
    public UnityEvent OnDamage => onDamage; 
    
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Bullet"))
        {
            // HP減少
            var b = other.gameObject.GetComponent<IBullet>();
            int hp = enemyHp.Add(-b.Damage);
            if (hp <= 0)
            {
                Destroy(this.gameObject);
                onDied?.Invoke();
            }
            
            // 弾の削除
            Destroy(other.transform.root.gameObject);
        }
    }
}
