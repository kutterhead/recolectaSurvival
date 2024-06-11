using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class elementoUIitem : MonoBehaviour
{
    // Start is called before the first frame update
    public Text textoNombre;
    public Text textoCantidad;
    public Sprite[] imagenesIconos;
    public Image imagenActual;

    public string[] nombresItems;
    
    
    public int tipoItem;






    void Start()
    {
        activaItem(2,13);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void activaItem(int index, int numElementos)
    {
        imagenActual.sprite = imagenesIconos[index];
        tipoItem = index;
        textoNombre.text = nombresItems[index];
        textoCantidad.text = numElementos.ToString();

    }


}
