using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Atirar : MonoBehaviour
{

    public GameObject bala;
    public Transform player;
    //float carga, cargaNecessaria = 5;

    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            //Carregar(bala);
            Vector3 posicao = new Vector3(transform.position.x, transform.position.y + 1, transform.position.z);
            GameObject instancia = Instantiate(bala, posicao, player.rotation);

            StartCoroutine(DestruirBala(instancia));
        }

    }
    IEnumerator DestruirBala(GameObject balinha)
    {
        yield return new WaitForSeconds(1.2f);
        Destroy(balinha);
    }
   /*IEnumerator Carregar(GameObject balinha)
    {
        yield return new WaitForSeconds(1);
        if (Input.GetKey(KeyCode.Mouse0))
        {
            print("funfa");
            carga += Time.deltaTime;
            if (Input.GetKeyUp(KeyCode.Mouse0))
            {
                if(carga >= cargaNecessaria)
                {
                    Vector3 posicao = new Vector3(transform.position.x, transform.position.y + 1, transform.position.z);
                    bala.transform.localScale = new Vector3(1, 1, 1);
                    GameObject instancia = Instantiate(bala, posicao, player.rotation);

                    StartCoroutine(DestruirBala(instancia));
                }
                else
                {
                    print("Sem carga");
                }
                
            }
        }
    }*/
}
