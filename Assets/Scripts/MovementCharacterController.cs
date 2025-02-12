using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementCharacterController : MonoBehaviour
{
    private CharacterController _characterController;
    
   void Start()
    {
        _characterController = GetComponent<CharacterController>();
    }

    void Update()
    {
        _characterController.SimpleMove(Vector3.right);
    }
}
