using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouvementRotate : MonoBehaviour
{

    void Update()
    {
        transform.Rotate(0f, Time.deltaTime * 10f, 0f);
    }
}
