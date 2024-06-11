using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cuchilloPerdidoScript : MonoBehaviour
{
    // Start is called before the first frame update


    void Start()
    {

        gameObject.transform.eulerAngles = new Vector3(Random.Range(0f,360f), Random.Range(0f, 360f), Random.Range(0f, 360f));
        gameObject.GetComponent<Rigidbody>().AddForce(transform.forward*1,ForceMode.Impulse);

        Destroy(gameObject, 3f);
    }

   
}
