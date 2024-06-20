using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class elementoTienda : MonoBehaviour
{
    public gameManager manager;
    public int indiceTipoObjeto;//describe el tipo de objeto
    


    public byte materiaIndex0;
    public byte materiaIndex1;
    public byte materiaIndex2;


    public Image imagenElemento;
    //imágenes locales de los recursos que cuesta el elemento
    public Image imagenMateria0;
    public Image imagenMateria1;
    public Image imagenMateria2;



    //es el coste de este artículo

    public string nombre;
    public int GoldValue;
    public int IronValue;
    public int WoodValue;

    public Text goldText;
    public Text ironText;
    public Text woodText;

    private void Awake()
    {
        manager = GameObject.FindGameObjectWithTag("gameManager").GetComponent<gameManager>();
    }
    void Start()
    {
        //por si acaso
        

        goldText.text = GoldValue.ToString();
        ironText.text = IronValue.ToString();
        woodText.text = WoodValue.ToString();

        iniciaImagenes();
    }

    public void iniciaImagenes()
    {
        print("Indice. " + indiceTipoObjeto);
        imagenElemento.sprite = manager.imagenesIconos[indiceTipoObjeto];

        imagenMateria0.sprite = manager.imagenesIconos[materiaIndex0];
        imagenMateria1.sprite = manager.imagenesIconos[materiaIndex1];
        imagenMateria2.sprite = manager.imagenesIconos[materiaIndex2];

        //if (manager.imagenesIconos[indiceTipoObjeto]==null)
        //{

        //    print("Objeto vacío");
        //}
        //else
        //{
        //    print("Objeto No vacío: " + manager.imagenesIconos[indiceTipoObjeto].name);
        //}

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
