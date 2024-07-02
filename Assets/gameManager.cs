using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameManager : MonoBehaviour
{
    // Start is called before the first frame update
    public Sprite[] imagenesIconos;//ejemplos de iconos
    public string[] nombresItems;
    
    public bool mostrarCeros;//variable usada para mostrar los iconos que estén a cero o no

    public Transform punteroItems;
    Vector3 posicionInicialPuntero;


    public GameObject itemUIPrefab;


    //no hace falta está de depuración
    public GameObject[] objetosConseguidos;

    public GameObject cuchilloPerdidoPrefab;
    public GameObject linternaPerdidaPrefab;



    public GameObject player;

    //almacena cuantos hay de cada tipo, ejemplo tipo 0 = cuchillo
    public int[] cantidadObjetosConseguidos;
    public GameObject[] elementosUIEnPantalla;


    //objeto que transporta en la mano y es oculto cuando no usa cuchillo
    public GameObject cuchilloEnMano;
    public GameObject linternaEnMano;






    void Start()
    {

        //inicializamos los arrays para que dependan sólo de uno, el de iconos.
        System.Array.Resize(ref nombresItems, imagenesIconos.Length);
        System.Array.Resize(ref cantidadObjetosConseguidos, imagenesIconos.Length);

        for(int i=0; i< imagenesIconos.Length; i++)
        {
            nombresItems[i] = imagenesIconos[i].name;
        }




        posicionInicialPuntero = punteroItems.position;
        ubicaObjetosUI();



    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ubicaObjetosUI()
    {

        //los eliminamos
        for (int i = 0; i < elementosUIEnPantalla.Length; i++)
        {
            Destroy(elementosUIEnPantalla[i]);

        }



        punteroItems.position = posicionInicialPuntero;

        //se ubican de nuevo
            for (int i = 0; i < cantidadObjetosConseguidos.Length; i++)
        {
            //este if ahhce que se muestren los que son mayor a cero únicamente


            if (!mostrarCeros)
            {
                if (cantidadObjetosConseguidos[i] > 0)
                {

                ubicar(i);

                }
            }
            else
            {
                ubicar(i);

            }





        }

        
    }

    private void ubicar(int i)
    {
        System.Array.Resize(ref elementosUIEnPantalla, elementosUIEnPantalla.Length + 1);

        //aquí se instancia un icono en el canvas de la izquierda
        GameObject prefab = Instantiate(itemUIPrefab, punteroItems.position, punteroItems.rotation);

        //lo pone bien "fromateado"
        prefab.transform.parent = punteroItems.parent;
        prefab.GetComponent<RectTransform>().sizeDelta = new Vector2(punteroItems.GetComponent<RectTransform>().sizeDelta.x, punteroItems.GetComponent<RectTransform>().sizeDelta.y);
        prefab.transform.localScale = Vector3.one;


        //se almacenan agrupados por tipo aqui
        elementosUIEnPantalla[elementosUIEnPantalla.Length - 1] = prefab;

        prefab.GetComponent<elementoUIitem>().activaItem(i, cantidadObjetosConseguidos[i]);


        float deltaY = punteroItems.GetComponent<RectTransform>().sizeDelta.y / 2;
        punteroItems.transform.position = new Vector3(punteroItems.transform.position.x, punteroItems.transform.position.y - deltaY, punteroItems.transform.position.z);
    }

    public void pierdeCuchillo()
    {
        //el objeto 0 es el cuchillo
        cantidadObjetosConseguidos[0]--;


        Instantiate(cuchilloPerdidoPrefab, cuchilloEnMano.transform.position, cuchilloEnMano.transform.rotation);
        UnHoldKnife();
    }
    public void pierdeLinterna()
    {
        Instantiate(linternaPerdidaPrefab, linternaEnMano.transform.position, linternaEnMano.transform.rotation);
        cantidadObjetosConseguidos[6]--;


    }
    
    public void incorporaObjetoEnIndice(int indice)
    {
        if (indice> cantidadObjetosConseguidos.Length-1 && indice <0)
        {
            print("Índice incorrecto");
            return;//no hace nada si el indice es mayor
        }

        cantidadObjetosConseguidos[indice] += 1;

        ubicaObjetosUI();
    }

    public void incorporaObjeto(GameObject objeto)
    {

        //almacena en un array de objetos
        System.Array.Resize(ref objetosConseguidos, objetosConseguidos.Length+1);
        objetosConseguidos[objetosConseguidos.Length-1] = objeto;

        int valor = objeto.GetComponent<Item>().numeroItem;


        cantidadObjetosConseguidos[valor] += 1;



        




        ubicaObjetosUI();

    }

    public void seleccionObjetoConseguido(int indice)
    {
        

        if (!(cantidadObjetosConseguidos[indice] > 0))
        {

            print("No hay elementos de tipo: " + nombresItems[indice]);
            return;
        }


        print("Objeto conseguido pulsado de tipo: " + indice);


        switch (indice)
        {
            case 0://es el cuchillo
                {
                    cuchilloEnMano.SetActive(!cuchilloEnMano.activeSelf);

                    linternaEnMano.SetActive(false);
                    print("Elemento " + nombresItems[6] + " activado");

                    //esta función pone en idle con arma y muestra el cuchillo

                    //HoldKnife();
                    break;

                }
            case 1://manzana
                {
                    break;
                }

            case 2://oro
                {
                    break;
                }
            case 3://madera
                {
                    break;
                }
            case 4://hierro
                {
                    break;
                }
            case 5://battería
                {
                    break;
                }
            case 6://hierro
                {

                    linternaEnMano.SetActive(!linternaEnMano.activeSelf);
                    cuchilloEnMano.SetActive(false);
                    print("Elemento "+  nombresItems[6] + " activado");
                   
                    
                    break;
                }
            case 7://hierro
                {
                    break;
                }
            default:
                {
                    print("No se ha encontrado valor");
                    break;
                }

        }
    }


    public void HoldKnife(){

        //activamos el booleano de mismo nombre HoldKnife para que entre en idle con cuchillo
        player.GetComponent<Animator>().SetBool("HoldKnife",true);
        cuchilloEnMano.SetActive(true);


    }
    public void UnHoldKnife()
    {

        //activamos el booleano de mismo nombre HoldKnife para que entre en idle con cuchillo
        player.GetComponent<Animator>().SetBool("HoldKnife", false);
        cuchilloEnMano.SetActive(false);


    }



}
