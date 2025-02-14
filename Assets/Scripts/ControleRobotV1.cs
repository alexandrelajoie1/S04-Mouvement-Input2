using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ControleRobotV1 : MonoBehaviour
{
    private Rigidbody _rb;
    Vector2 directionMouvement;

    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    void OnMove(InputValue valeur)
    {
        directionMouvement = valeur.Get<Vector2>();
    }

    void FixedUpdate()
    {
        Vector3 directionSurPlane = new Vector3(directionMouvement.x, 0, directionMouvement.y);
        _rb.AddForce(directionSurPlane, ForceMode.VelocityChange);
        //if (directionSurPlane.magnitude > 0.01f)
        //{
        //    _rb.MoveRotation(Quaternion.LookRotation(directionSurPlane, Vector3.up));
        //}
    }
}
