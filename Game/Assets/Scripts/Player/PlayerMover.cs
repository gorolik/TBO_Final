using UnityEngine;
using System;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMover : MonoBehaviour
{
    [SerializeField] private float _movementSpeed;
    [SerializeField] private float _flyForce;

    public Action<float> Moving;
    public Action Flying;

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
        Fly();
    }

    private void Movement()
    {
        float movement = Input.GetAxis("Horizontal");
        _rigidbody.AddForce(Vector2.right * movement * _movementSpeed * Time.deltaTime);

        Moving?.Invoke(movement);
    }

    private void Fly()
    {
        if(Input.GetKey(KeyCode.Space))
        {
            _rigidbody.AddForce(Vector2.up * _flyForce * Time.deltaTime);

            Flying?.Invoke();
        }
    }
}
