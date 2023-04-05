using UnityEngine;

public class PlayerHealth : Health
{
    public delegate void PlayerDied();
    public static PlayerDied OnPlayerDied;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.TryGetComponent(out Killer killer))
        {
            Die();
            OnPlayerDied();
        }
    }
}
