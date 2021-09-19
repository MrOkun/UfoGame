using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Rigidbody))]
public class PlayerMove : MonoBehaviour
{
    [SerializeField] private float _speed;

    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(Vector2.up * _speed);
        }
        if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(Vector2.down * _speed);
        }
    }
}
