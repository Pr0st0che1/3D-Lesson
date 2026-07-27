using UnityEngine;

public class Rotation : MonoBehaviour
{
    [SerializeField] private float _roteionSpeed = 0.5f;

    private void Update()
    {
        transform.Rotate(0, _roteionSpeed, 0);
    }
}
