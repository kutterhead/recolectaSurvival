using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class detectorColission : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject manager;

    void Start()
    {
        //por si acaso
        manager = GameObject.FindGameObjectWithTag("gameManager");
    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("Item"))
        {

            print("Colisión con Item");


            manager.GetComponent<gameManager>().incorporaObjeto(other.gameObject);
            
            
            //de momento ocultamos el objeto recién cogido.
            other.gameObject.SetActive(false);


        }


        
    }


}
