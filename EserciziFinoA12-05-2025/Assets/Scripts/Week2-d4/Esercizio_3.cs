using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Esercizio_3 : MonoBehaviour
{
    public int numero;
    public string f = "fizz";
    public string b = "buzz";
    public string fb = "fizzbuzz";
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 30; i++)
        {
            numero++;


            if (numero / 3 == 0)
            {
                Debug.Log(f);
            }else if(numero / 5 == 0)
            {
                Debug.Log(b);
            }

            if(numero / 3 == 0 & numero / 5 == 0)
            {
                Debug.Log(fb);
            }




        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
