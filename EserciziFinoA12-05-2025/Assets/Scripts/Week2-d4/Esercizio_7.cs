using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Esercizio_7 : MonoBehaviour
{
  public  int[] array = new int[20];

    public int min;
    public int max;


    private void Start()
    {      
        GeneraArray(array, min, max);
    }
    public void GeneraArray(int[] ints, int mi, int mx)
    {

        for (int i = 0; i < ints.Length; i++)
        {

            int n = Random.Range(mi, mx);
            ints[i] = n;
            Debug.Log(ints[i]);

        }

    }
}
