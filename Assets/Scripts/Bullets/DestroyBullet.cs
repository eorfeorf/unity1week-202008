using System;
using UnityEngine;

namespace Bullets
{
    public class DestroyBullet : MonoBehaviour
    {
        public Action<GameObject> OnHitEnemy { get; set; }

        private void OnCollisionEnter(Collision other)
        {
            if (other.gameObject.CompareTag("Enemy"))
            {
                //OnHitEnemy?.Invoke();
            }
        }
    }
}