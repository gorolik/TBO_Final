using UnityEngine;
using System;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMover : MonoBehaviour
{
    [SerializeField] private float _movementSpeed;
    [SerializeField] private float _jumpingForce;

    public Action<float> Moving;

    private Rigidbody2D _rigidbody;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (_rigidbody == null)
            return;

        Movement();
        Jumping();
    }

    private void Movement()
    {
        float movement = Input.GetAxis("Horizontal");
        _rigidbody.AddForce(Vector2.right * movement * _movementSpeed * Time.deltaTime);

        Moving?.Invoke(movement);
    }

    private void Jumping()
    {
        if(Input.GetKey(KeyCode.Space))
        {
            _rigidbody.AddForce(Vector2.up * _jumpingForce * Time.deltaTime);
        }
    }
}
