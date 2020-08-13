using UnityEngine;

namespace Guns
{
    public class NormalGun : MonoBehaviour
    {
        //private float shotTimer = 0.0f;
        [SerializeField] private GameObject normalBullet = default;
        
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
                Instantiate(normalBullet, EmitterTransform.position, Quaternion.identity);
            }
        }
    }
}