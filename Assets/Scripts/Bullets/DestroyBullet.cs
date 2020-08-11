using UnityEngine;

namespace Bullets
{
    public class DestroyBullet : MonoBehaviour
    {
        private void OnCollisionEnter(Collision other)
        {
            if (other.gameObject.CompareTag("DestroyFrame"))
            {
                Destroy(this.transform.root.gameObject);
            }
        }
    }
}