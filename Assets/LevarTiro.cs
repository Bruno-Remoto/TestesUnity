using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevarTiro : MonoBehaviour
{
    public GameObject Tiro;
    public GameObject Inimigo;
    void Start()
    {
        
    }

    void Update()
    {
                
    }

    private void OnCollisionStay(Collision collision)
    {

        GameObject instancia = Tiro.gameObject;
        if (collision.collider.gameObject.tag == "Tiro")
        {
            Destroy(collision.collider.gameObject);
        }
    }
}
