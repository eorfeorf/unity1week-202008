using UnityEngine;
using Weapons;

namespace Guns
{
    public class ThreeWayGun : MonoBehaviour, IGun
    {
        [SerializeField] private GameObject bullet = default;
        [SerializeField] private float maxTime = 2.0f;

        public Transform EmitterTransform { get; set; }

        private readonly bool _isActive = true;
        private float _shotTimer = 0.0f;

        private void Update()
        {
            if (_isActive)
            {
                MakeUpdate();
            }
        }

        private void MakeUpdate()
        {
            _shotTimer += Time.deltaTime;
            if (_shotTimer > maxTime)
            {
                _shotTimer -= maxTime;
                var bulletParent = Instantiate(bullet, EmitterTransform.position, Quaternion.identity);
                Destroy(bulletParent);
            }
        }
    }
}