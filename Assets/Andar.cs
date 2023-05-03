using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Andar : MonoBehaviour
{
    float vloecidade = 10;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal") * vloecidade * Time.deltaTime;
        float v = Input.GetAxis("Vertical") * vloecidade * Time.deltaTime;

        transform.Translate(0, 0, v);
        transform.Rotate(0, h*10, 0);


    }
    private void OnCollisionExit(Collision collision)
    {
        if(collision.collider.tag == "Chao")
        {
            GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePositionY | RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationY
                                | RigidbodyConstraints.FreezeRotationZ; 
        }
    }
}
