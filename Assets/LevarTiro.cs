using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevarTiro : MonoBehaviour
{
    public GameObject Tiro;
    public GameObject Inimigo;
    bool isGay = false;
    public GameObject BalaGay;
    public GameObject BalaHetero;
    void Start()
    {
        
    }

    void Update()
    {
        if (isGay)
        {
            GetComponent<Renderer>().material.color = Color.magenta;
        }
        else
        {
            GetComponent<Renderer>().material.color = Color.red;
        }
    }

    private void OnTriggerStay(Collider collision)
    {
        if (collision.gameObject.tag == "TiroGay")
        {
            Destroy(collision.gameObject);
            isGay = true;
        }
        if (collision.gameObject.tag == "TiroHetero")
        {
            Destroy(collision.gameObject);
            isGay = false;
        }

        if (collision.gameObject.tag == "TiroGay" && GetComponent<Renderer>().material.color == Color.magenta)
        {
            GetComponent<Transform>().localScale += new Vector3(1, 1, 1); 
        }
        else
        {
            GetComponent<Transform>().localScale = new Vector3(1, 1, 1);
        }
    }
}
