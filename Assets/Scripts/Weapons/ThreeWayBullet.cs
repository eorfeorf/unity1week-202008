using System;
using System.Threading;
using UnityEngine;

namespace Bullets
{
    public class ThreeWayBullet : MonoBehaviour, IBullet
    {
        [SerializeField] private int damage = 1;

        public int Damage
        {
            get => damage;
            set { }
        }
    }
}
