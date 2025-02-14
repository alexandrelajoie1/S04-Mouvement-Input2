using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouvementRigidbody : MonoBehaviour
{
    private Rigidbody _rb;
    
    void Start()
    {
        // Prends une réference au Rigidbody attaché a cet objet.
        _rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        // Vector3 nouvellePosition = _rb.position + new Vector3(1f * Time.fixedDeltaTime, 0f, 0f);
        // _rb.MovePosition(nouvellePosition);

        _rb.velocity = transform.TransformDirection(Vector3.forward);
    }
}
