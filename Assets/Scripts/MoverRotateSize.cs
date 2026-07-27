using UnityEngine;

public class SimpleComplexCube : MonoBehaviour
{
    [SerializeField] private Vector3 _movementDirection;
    [SerializeField] private float growthSpeed = 0.01f;

    void Update()
    {
        transform.position += _movementDirection;
        transform.Rotate(0, -0.5f, 0);
        transform.localScale += Vector3.one * growthSpeed;
    }
}
