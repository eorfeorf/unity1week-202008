using UnityEngine;
using Weapons;

namespace Guns
{
    public class NormalGun : MonoBehaviour, IGun
    {
        //private float shotTimer = 0.0f;
        [SerializeField] private GameObject bullet = default;
        
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
                //Debug.Log(EmitterTransform.position);
                var bulletParent = Instantiate(bullet, EmitterTransform.position, Quaternion.identity);
                Destroy(bulletParent);
            }
        }
    }
}