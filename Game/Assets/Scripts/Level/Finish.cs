using UnityEngine;

public class Finish : MonoBehaviour
{
    [SerializeField] private float _finishDistance = 5;

    public delegate void Finished();
    public static Finished OnFinished;

    private Transform _player;
    private bool _finished;

    private void Start()
    {
        _player = FindObjectOfType<Player>().transform;
    }

    private void Update()
    {
        TryFinish();   
    }

    private void TryFinish()
    {
        if (_finished == true)
            return;

        if (Vector2.Distance(transform.position, _player.position) < _finishDistance)
        {
            _finished = true;
            OnFinished?.Invoke();
        }
    }
}
