using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Esercitazione_3 : MonoBehaviour
{
    public int max;
    public int max2;


    public int[] arr = new int[0];



    private void Start()
    {
        for (int i = 0; i < arr.Length; i++)
        {
            int number = arr[i];

            if (number > max)
            {
                max = number;
            }
            else if (number > max2 && number <= max)
            {
                max2 = number;
            }

}
    }
}
