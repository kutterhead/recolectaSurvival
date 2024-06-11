using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class elementoRecolectado : MonoBehaviour
{
    // Start is called before the first frame update

    public int tipoItem;
    private GameObject manager;



    public Sprite[] fotoImagen;

    public Text textoNumeroItems;
    void Start()
    {
        manager = GameObject.FindGameObjectWithTag("gameManager");

        SetItem(tipoItem);
    }


    //hace set de un item del tipo requerido por el índice
    public void SetItem(int index)
    {
        tipoItem = index;//ejemplo 0 = cuchillo
        int numeroCuchillos = manager.GetComponent<gameManager>().cantidadObjetosConseguidos[tipoItem];
        textoNumeroItems.text = numeroCuchillos.ToString();
        GetComponent<Image>().sprite = fotoImagen[index];


    }


}
