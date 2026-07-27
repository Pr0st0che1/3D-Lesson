using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SizeIncresing : MonoBehaviour
{
    [SerializeField] private float _growthSpeed = 0.05f;

    void Update()
    {
        transform.localScale += Vector3.one * _growthSpeed;
    }
}
