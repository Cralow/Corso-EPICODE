using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Esercitazione_2 : MonoBehaviour
{
    public int[] array = new int[20];

    public int min;
    public int max;


    private void Start()
    {
        int[] stamp;

        stamp = GeneraArray(array, min, max);

        StampaArray(stamp);
        TrovaMinimo(stamp);
        TrovaMassimo(stamp);

    }
    public int[] GeneraArray(int[] ints, int mi, int mx)
    {

        for (int i = 0; i < ints.Length; i++)
        {

            int n = Random.Range(mi, mx);
            ints[i] = n;
            Debug.Log(ints[i]);

        }
        return ints;
    }
    public void StampaArray(int[] n)
    {
        for (int i = 0; i < n.Length; i++)
        {
            Debug.Log(n[i]);
        }
    }


    public void TrovaMinimo(int[] n)
    {
        // int minimum = n.GetLowerBound(0);
        for(int i = 0;i < n.Length; i++)
        {
            

        }

    }

    public int TrovaMassimo(int[] n)
    {
        int max = n.GetUpperBound(n.Length);
        Debug.Log(max);
        return max;
    }

}
