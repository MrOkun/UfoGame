using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Rigidbody))]
public class MeteorMove : MonoBehaviour
{
    [SerializeField] private float _speed;
    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(Vector2.left * _speed);
    }
}
