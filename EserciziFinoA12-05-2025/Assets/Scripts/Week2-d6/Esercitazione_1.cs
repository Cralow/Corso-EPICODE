using System;
using System.Collections;
using UnityEngine;

public class Esercitazione_1 : MonoBehaviour
{
    public int base_;
    public int multiple;

    public int pari;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        IsEven(pari);
        IsMultiple(base_, multiple);
        
    }


    
    public Boolean IsEven(int n)
    {

        if (n / 2 == 0)
        {
            Debug.Log("il numero è pari");
            return true;
        }
        
        else return false;
        
    }

    public Boolean IsMultiple(int a, int b)
    {
        if (a / b == 0) return true;
        else return false;

    }
}
