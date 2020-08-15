using System;
using System.Threading;
using UnityEngine;

namespace Bullets
{
    public class ThreeWayBullet : MonoBehaviour, IBullet
    {
        [SerializeField] private int damage = 1;

        private void Awake()
        {
            this.transform.SetParent(null);
        }

        public int Damage
        {
            get => damage;
            set { }
        }
    }
}
