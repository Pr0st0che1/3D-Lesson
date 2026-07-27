using UnityEngine;

public class movingForward : MonoBehaviour
{
    [SerializeField] private float _speed = 0.01f;

    private void Update()
    {
        transform.position += transform.forward * _speed;
    }
}
