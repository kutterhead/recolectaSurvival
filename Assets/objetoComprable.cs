using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objetoComprable : MonoBehaviour
{
    public GameObject manager;

    void Start()
    {
        //por si acaso
        manager = GameObject.FindGameObjectWithTag("gameManager");
    }
    // Update is called once per frame
   
    

}
