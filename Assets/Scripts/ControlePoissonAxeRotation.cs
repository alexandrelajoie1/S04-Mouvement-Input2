using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ControlePoissonAxeRotation : MonoBehaviour
{
    private Rigidbody _rb;
    float angle = 0f;

    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    void OnTourner(InputValue valeur)
    {
        angle = valeur.Get<float>();
    }

    private void FixedUpdate()
    {
        _rb.AddRelativeTorque(0, angle, 0, ForceMode.VelocityChange);
    }
}
