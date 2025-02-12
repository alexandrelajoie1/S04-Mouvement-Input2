using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouvementTranslateSelf : MonoBehaviour
{
    [SerializeField] Vector3 direction;
    [SerializeField] float vitesse;

    void Update()
    {
        //transform.Translate(direction.normalized * vitesse * Time.deltaTime, Space.World);
        transform.Translate(direction.normalized * vitesse * Time.deltaTime, Space.Self);
    }
}
