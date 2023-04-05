using UnityEngine;

public class CameraMover : MonoBehaviour
{
    [SerializeField] private float _damping;
    [SerializeField] private Vector2 _offset;
    [SerializeField] private Transform _player;

    private void LateUpdate()
    {
        float x = Mathf.Lerp(transform.position.x, _player.position.x, Time.deltaTime * _damping);
        float y = Mathf.Lerp(transform.position.y, _player.position.y, Time.deltaTime * _damping);
        float z = -10;

        Vector3 position = new Vector3(x, y, z) + (Vector3)_offset;

        transform.position = position;
    }
}
