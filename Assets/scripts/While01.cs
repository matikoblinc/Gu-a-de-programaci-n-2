using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class While01 : MonoBehaviour
{
    public int counter;
    public int counterMax;

    void Start()
    {
        while (counter <= counterMax)
        {
            Debug.Log("esto se está repitiendo por vex numero " + counter);
            counter++;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
