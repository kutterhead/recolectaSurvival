using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class muroMetal : MonoBehaviour
{
    private GameObject player;
    private GameObject manager;



    void Start()
    {
        // vida = 3;
        player = GameObject.FindGameObjectWithTag("Player");
        manager = GameObject.FindGameObjectWithTag("gameManager");
    }


    private void OnTriggerEnter(Collider other)
    {
        bool hasKnife = player.GetComponent<Animator>().GetBool("HoldKnife");
        if (other.gameObject.CompareTag("Cuchillo") && hasKnife) 
        {
            print("Colision detectada con cuchillo, debe ser eliminado");
            //se desactiva cuando el cuchillo se pierde
            player.GetComponent<Animator>().SetBool("HoldKnife", false);


            //esto destruye al cuchillo


            //Destroy(other.gameObject);

            manager.GetComponent<gameManager>().pierdeCuchillo();


        }

        if (other.gameObject.CompareTag("Linterna")) 
        {
            print("Colision detectada con linterna, debe ser eliminada");
            //se desactiva cuando el cuchillo se pierde


            manager.GetComponent<gameManager>().linternaEnMano.SetActive(false);
            manager.GetComponent<gameManager>().pierdeLinterna();


        }




    }
}
