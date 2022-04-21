using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej02 : MonoBehaviour
{
    public int inicial;
    public int final;

    void Start()
    {

        if (inicial == final)
        {
            Debug.Log("los numeros son iguales");
        }
        else if (final > inicial)
        {
            Debug.Log("el final no puede ser mayor que el inicial");
        }
        else
        {
            while (inicial >= final)
            {
                Debug.Log("uno de los numeros entre ambos es " +inicial);
                inicial--;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
