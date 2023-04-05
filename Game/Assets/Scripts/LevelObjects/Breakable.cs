using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Breakable : MonoBehaviour
{
    private Rigidbody2D _rigidbody;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.TryGetComponent(out Player player))
        {
            Break();
        }
    }

    private void Break()
    {
        _rigidbody.simulated = true;
    }
}
