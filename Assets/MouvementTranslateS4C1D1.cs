using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouvementTranslateS4C1D1 : MonoBehaviour
{
    void Update()
    {
        transform.Translate(1f * Time.deltaTime, 0, 0, Space.World);

        //Vector3 deplacement = new Vector3(1f, 0, 0);
        //transform.Translate(deplacement * Time.deltaTime, Space.World);
    }
}
