using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq.Expressions;
using Unity.VisualScripting;
using UnityEngine;

public class Esercizio_2 : MonoBehaviour
{

    public int a;
    public int b;
    public int c;
    public int d;
    // Start is called before the first frame update
    void Start()
    {
        int[] listaArray = { a, b, c, d };

        for (int i = 0; i <= listaArray.Length; i++)
        {
            float somma = listaArray[0] + listaArray[1] + listaArray[2] + listaArray[3];
            float prodotto = listaArray[0] * listaArray[1] * listaArray[2] * listaArray[3];
            Debug.Log(somma);
            Debug.Log(prodotto);


        


        }

    }

   
    
    
    
    
    
    
    
    
    
  
}
