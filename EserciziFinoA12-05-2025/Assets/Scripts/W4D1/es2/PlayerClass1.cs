using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Experimental.GraphView.GraphView;

public class PlayerClass1
{
    public string name;
    private int punteggio;

    private int modificatore = 5;
    public void Stampa()
    {

        Debug.Log("Arriva: " + name + " con un livello di: " + punteggio.ToString());
     
    }
    public void IncrementaPunteggio()
    {

       punteggio += modificatore;

        Debug.Log( name + " aumenta il suo livello arrivando a: " + punteggio.ToString() + " punti");
    }
    public int GetPunteggio()
    {
        return punteggio;
    }
    public void SetPunteggio(int n) 
    {
        if(n < 0)
        {
            n = 0;
        }
        punteggio = n;

    }

}
