using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movingForward : MonoBehaviour
{
    [SerializeField] private Vector3 _movementDirection;

    private void Update()
    {
        transform.position += _movementDirection;
    }
}
