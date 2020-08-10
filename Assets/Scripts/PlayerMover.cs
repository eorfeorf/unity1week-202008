using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMover : MonoBehaviour
{
    [SerializeField] private float speed = 1.0f;
    
    private Transform transform;

    void Start()
    {
        transform = GetComponent<Transform>();
    }

    void Update()
    {
        var velocity = Vector3.zero;
        
        velocity.x = Input.GetAxis("Horizontal");
        velocity.z = Input.GetAxis("Vertical");

        velocity = velocity.normalized * speed;
        
        Debug.Log(velocity);
        transform.position += velocity * Time.deltaTime;
    }
}
