using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverTiro : MonoBehaviour
{
    float vloecidade = 10;
    public GameObject bala;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float vloecidadeTiro = vloecidade * Time.deltaTime;

        transform.Translate(0, 0, vloecidadeTiro);
    }
}