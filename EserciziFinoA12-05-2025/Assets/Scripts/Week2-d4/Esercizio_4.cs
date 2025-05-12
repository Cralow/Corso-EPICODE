using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Esercizio_4 : MonoBehaviour
{
    public int amount;
    public int start;

    private void Start()
    {
        Debug.Log(start.ToString());
        
        for (int i = 0; i < amount; i++)
        {
            
            Debug.Log(start + 1);
            start++;
            amount--;


        }
    }


}
