using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class elementoTienda : MonoBehaviour
{
    public gameManager manager;
    public int indiceTipoObjeto;//describe el tipo de objeto



    void Start()
    {
        //por si acaso
        manager = GameObject.FindGameObjectWithTag("gameManager").GetComponent<gameManager>();
    }


    //es el coste de este artículo

    public string nombre;
    public int GoldValue;
    public int IronValue;
    public int WoodValue;

    public void compraObjeto()
    {
        int TotalGold = manager.cantidadObjetosConseguidos[2];
        int TotalWood = manager.cantidadObjetosConseguidos[3];
        int TotalIron = manager.cantidadObjetosConseguidos[4];


        print("oro total: " + TotalGold);
        print("madera total: " + TotalWood);
        print("hierro total: " + TotalIron);


        print("objeto Comprado");



    }



}
