using UnityEngine;

public class PlayerView : MonoBehaviour
{
    [SerializeField] private PlayerMover _mover;
    [SerializeField] private Transform _player;
    [SerializeField] private Transform _view;

    private void OnEnable()
    {
        _mover.Moving += OnPlayerMoving;
    }

    private void OnDisable()
    {
        _mover.Moving -= OnPlayerMoving;
    }

    private void OnPlayerMoving(float movement)
    {
        float scaleValue;
        if (movement >= 0)
            scaleValue = 1;
        else
            scaleValue = -1;

        _view.localScale = new Vector3(scaleValue, _view.localScale.y, _view.localScale.z);
    }
}
