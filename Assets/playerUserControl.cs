using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerUserControl : MonoBehaviour
{
    // Start is called before the first frame update

    private Animator anim;
    public GameObject manager;
    private bool desarmaArma;


    void Start()
    {
        //captura animator de su propio objeto
        anim = GetComponent<Animator>();
        manager = GameObject.FindGameObjectWithTag("gameManager");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0) && anim.GetBool("HoldKnife"))
        {
            print("Acuchillando");

            anim.SetTrigger("Stab");

        }

        //permitimos entrar cuando se pulsa el botón y hay cuchillos
        if (Input.GetKeyDown(KeyCode.Alpha1) && manager.GetComponent<gameManager>().cantidadObjetosConseguidos[0]>0)
        {
            desarmaArma = !desarmaArma;
            //print("detectada pulsacion");
            if (desarmaArma)
            {
                //print("arma");
                manager.GetComponent<gameManager>().HoldKnife();
            }
            else
            {
                //print("desarma");
                manager.GetComponent<gameManager>().UnHoldKnife();
            }
        }
        

           



    }
}
