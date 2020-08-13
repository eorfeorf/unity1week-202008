using UnityEngine;
using Weapons;

namespace Guns
{
    public class ThreeWayGun : MonoBehaviour, IGun
    {
        //private float shotTimer = 0.0f;
        [SerializeField] private GameObject bullet = default;
        
        public Transform EmitterTransform { get; set; }
        
        private bool isActive = true;

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
                Instantiate(bullet, EmitterTransform.position, Quaternion.identity);
            }
        }
    }
}