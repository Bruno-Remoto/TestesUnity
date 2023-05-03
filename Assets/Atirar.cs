using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Atirar : MonoBehaviour
{

    public GameObject bala;
    public Transform player;
    public GameObject TiroGay;
    public GameObject TiroHetero;
    //float carga, cargaNecessaria = 5;
    bool Gayzificar = true;
    public GameObject Textinho;
    string textoArma;
    private void Start()
    {
        textoArma = "Modo da Arma: Gayzificar";
    }
    void Update()
    {
        Textinho.GetComponent<TMPro.TextMeshProUGUI>().text = textoArma;
        if (Input.GetKeyDown(KeyCode.F))
        {
            if (Gayzificar)
            {
                Gayzificar = false;
                textoArma = "Modo da arma: Desgayzificar";
            }
            else
            {
                Gayzificar = true;
                textoArma = "Modo da arma: Gayzificar";
            }
            if (Gayzificar)
            {
                bala = TiroGay;
            }
            else
            {
                bala = TiroHetero;
            }
        }
        
        
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            //Carregar(bala);
            Vector3 posicao = new Vector3(transform.position.x, transform.position.y+1, transform.position.z);
            GameObject instancia = Instantiate(bala, posicao, player.rotation);

            Destroy(instancia, 1.2f);
        }

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
