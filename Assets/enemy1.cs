using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy1 : MonoBehaviour
{
    // Start is called before the first frame update
    public int vida;
    private GameObject player;




    void Start()
    {
        // vida = 3;
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame


    private void OnTriggerEnter(Collider other)
    {
        bool hasKnife = player.GetComponent<Animator>().GetBool("HoldKnife");
        if (other.gameObject.CompareTag("Cuchillo") && hasKnife);
        {
            print("Colision detectada con cuchillo");
            vida--;
            if (vida<1)
            {
               



                Destroy(gameObject);
            }

        }
       
    
    
        
    }

}
