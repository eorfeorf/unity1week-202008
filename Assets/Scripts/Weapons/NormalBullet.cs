using Bullets;
using UnityEngine;

namespace Weapons
{
    public class NormalBullet : MonoBehaviour, IBullet
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
