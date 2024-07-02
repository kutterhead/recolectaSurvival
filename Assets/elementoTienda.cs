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

    //es el coste de este artículo


    public int costoMateria0;
    public int costoMateria1;
    public int costoMateria2;


    public Image imagenElemento;
    //imágenes locales de los recursos que cuesta el elemento, son la referencia par acopiar los sprites en ellas
    public Image imagenMateria0;
    public Image imagenMateria1;
    public Image imagenMateria2;





    public Text goldText;
    public Text ironText;
    public Text woodText;
    public Text nameText;

    string nombre;
    private void Awake()
    {
        manager = GameObject.FindGameObjectWithTag("gameManager").GetComponent<gameManager>();
    }
    void Start()
    {
        //por si acaso
        

        goldText.text = costoMateria0.ToString();
        ironText.text = costoMateria1.ToString();
        woodText.text = costoMateria2.ToString();
        nameText.text = manager.nombresItems[indiceTipoObjeto];


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


        //if (TotalGold >= costoMateria0)
        //{
        //    print("Si puedes G:");
        //}
        //else
        //{
        //    print("no puedes G:");
        //}
        //if (TotalWood >= costoMateria2)
        //{
        //    print("Si puedes W:");
        //}
        //else
        //{
        //    print("no puedes W:");
        //}
        //if (TotalIron >= costoMateria1)
        //{
        //    print("Si puedes I:");
        //}
        //else
        //{
        //    print("no puedes I:" + TotalIron + " " + costoMateria1);
        //}


        if ((TotalGold>= costoMateria0) && (TotalWood>= costoMateria2) && (TotalIron>= costoMateria1))
        {
            TotalGold -= costoMateria0;
            TotalWood -= costoMateria2;
            TotalIron -= costoMateria1;

            print("oro total: " + TotalGold);
            print("madera total: " + TotalWood);
            print("hierro ttal: " + TotalIron);
            manager.cantidadObjetosConseguidos[2] -= costoMateria0;//oro
            manager.cantidadObjetosConseguidos[3] -= costoMateria2;//madera
            manager.cantidadObjetosConseguidos[4] -= costoMateria1;//Hierro
            manager.incorporaObjetoEnIndice(indiceTipoObjeto);


            print("objeto Comprado");

        }
        else
        {
            print("No se puede realizar la fabricación faltan recursos");
        }

        



    }



}
