using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationObstacle : MonoBehaviour
{
    [SerializeField] private float rotationSpeedMax;
    [SerializeField] private float rotationSpeedMin;
    private float rotationZ;
    private float rotationSpeed;

    void Start()
    {
        rotationSpeed = Random.Range(rotationSpeedMin, rotationSpeedMax);
    }

    void Update()
    {
        rotationZ += Time.deltaTime * rotationSpeed;
        transform.rotation = Quaternion.Euler (0,0, rotationZ);
    }
}
