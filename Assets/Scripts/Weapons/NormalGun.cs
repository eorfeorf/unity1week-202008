using UnityEngine;
using Weapons;

namespace Guns
{
    public class NormalGun : MonoBehaviour, IGun
    {
        [SerializeField] private GameObject bullet = default;
        [SerializeField] private float maxTime = 2.0f;
                
        private bool isActive = true;
        
        public Transform EmitterTransform { get; set; }

        private void Update()
        {
            if (isActive)
            {
                MakeUpdate();
            }
        }

        private void MakeUpdate()
        {
            if (Input.GetKeyDown(KeyCode.Z))
            {
                var bulletParent = Instantiate(bullet, EmitterTransform.position, Quaternion.identity);
                Destroy(bulletParent);
            }
        }
    }
}