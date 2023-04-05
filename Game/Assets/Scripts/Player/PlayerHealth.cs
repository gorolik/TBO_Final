using UnityEngine;

public class PlayerHealth : Health
{
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.TryGetComponent(out Killer killer))
        {
            Die();
        }
    }
}
