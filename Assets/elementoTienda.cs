using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class elementoTienda : MonoBehaviour
{
    public gameManager manager;
    public int indiceTipoObjeto;//describe el tipo de objeto


    //es el coste de este artículo

    public string nombre;
    public int GoldValue;
    public int IronValue;
    public int WoodValue;

    public Text goldText;
    public Text ironText;
    public Text woodText;

    void Start()
    {
        //por si acaso
        manager = GameObject.FindGameObjectWithTag("gameManager").GetComponent<gameManager>();

        goldText.text = GoldValue.ToString();
        ironText.text = IronValue.ToString();
        woodText.text = WoodValue.ToString();
    }



    public void compraObjeto()
    {
        int TotalGold = manager.cantidadObjetosConseguidos[2];//oro
        int TotalWood = manager.cantidadObjetosConseguidos[3];//madera
        int TotalIron = manager.cantidadObjetosConseguidos[4];//Hierro

        //print("valores totales:");
        //print(TotalGold + " " + TotalWood + " " + TotalIron);


        //if (TotalGold >= GoldValue)
        //{
        //    print("Si puedes G:");
        //}
        //else
        //{
        //    print("no puedes G:");
        //}
        //if (TotalWood >= WoodValue)
        //{
        //    print("Si puedes W:");
        //}
        //else
        //{
        //    print("no puedes W:");
        //}
        //if (TotalIron >= IronValue)
        //{
        //    print("Si puedes I:");
        //}
        //else
        //{
        //    print("no puedes I:" + TotalIron + " " + IronValue);
        //}


        if ((TotalGold>= GoldValue) && (TotalWood>= WoodValue) && (TotalIron>= IronValue))
        {
            TotalGold -= GoldValue;
            TotalWood -= WoodValue;
            TotalIron -= IronValue;

            print("oro total: " + TotalGold);
            print("madera total: " + TotalWood);
            print("hierro ttal: " + TotalIron);
            manager.cantidadObjetosConseguidos[2] -= GoldValue;//oro
            manager.cantidadObjetosConseguidos[3] -= WoodValue;//madera
            manager.cantidadObjetosConseguidos[4] -= IronValue;//Hierro
            manager.incorporaObjetoEnIndice(indiceTipoObjeto);


            print("objeto Comprado");

        }
        else
        {
            print("No se puede realizar la fabricación faltan recursos");
        }

        



    }



}
