using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Esercizio_6 : MonoBehaviour
{
    public int[] array= new int[20];

    public int[] arraySomma;

    void Start()
    {
        GeneraArray();
        SommaArray();
        StampaArray(arraySomma);
        StampaArray(array);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GeneraArray()
    {

        for (int i = 0; i < array.Length; i++)
        {

            int n = Random.Range(0, 100);
            array[i] = n;
            //Debug.Log(array[i]);

        }
    }

    public void SommaArray()
    {
        int somma = 0;
        for (int i = 0;i < arraySomma.Length; i++)
        {
          somma +=arraySomma[i];
        }
        Debug.Log(somma);

    }

    public void StampaArray(int[] ints)
    {
       
        for (int i = 0; i < ints.Length; i++)
        {

          string st = ints[i].ToString();
           Debug.Log(st);
           
        }
       
    }
}
