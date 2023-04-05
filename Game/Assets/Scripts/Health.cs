using UnityEngine;
using System;

public class Health : MonoBehaviour
{
    public Action OnDie;

    private bool _alive = true;

    public void Die()
    {
        if (_alive == false)
            return;

        _alive = false;
        OnDie?.Invoke();
    }
}
