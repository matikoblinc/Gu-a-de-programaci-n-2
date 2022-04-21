using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej01 : MonoBehaviour
{
    public int inicio;
    public int final;

    void Start()
    {
        while (inicio <= final)
        {
            Debug.Log(inicio);
            inicio++;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
