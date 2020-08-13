using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StraightMover : MonoBehaviour
{
    [SerializeField] private float speed = 5.0f;
 
    private Transform transform;
    
    public float Speed
    {
        get => speed;
        set { }
    }

    private void Awake()
    {
        transform = GetComponent<Transform>();
    }
    
    void Update()
    {
        Vector3 v = transform.forward;
        v = v * (speed * Time.deltaTime);
        transform.position += v;
    }
}
