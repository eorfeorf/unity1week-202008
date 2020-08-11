using System;
using System.Threading;
using UnityEngine;

namespace Bullets
{
    public class NormalBullet : MonoBehaviour
    {
        [SerializeField] private Transform transform;
        [SerializeField] private float speed = 5.0f;

        private void Awake()
        {
            transform = GetComponent<Transform>();
        }

        void Start()
        {
        }

        void Update()
        {
            Vector3 v = Vector3.zero;
            v.z = speed * Time.deltaTime;
            transform.position += v;
        }
    }
}
