using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouvementRotateS4C1D3 : MonoBehaviour
{

    void Update()
    {
        transform.Rotate(0f, Time.deltaTime * 10f, 0f);
    }
}
