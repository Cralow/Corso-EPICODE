using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.FullSerializer;
using UnityEngine;
using static UnityEditor.Experimental.GraphView.GraphView;

public class PlayerClass3
{
    public string name;
    private int punteggio;

    private int modificatore = 150;
    public void Stampa()
    {

        Debug.Log("Ora: " + name + " ha un livello di: " + punteggio.ToString());
     
    }
    public void IncrementaPunteggio()
    {

       punteggio += modificatore;

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

        Stampa();
        IsVincitore();
     

    }
    public bool IsVincitore()
    {
        if (punteggio >= 100)
        {
            Debug.Log("Vince " + name + " !!!!");
            return true;
        }
        else
            return false;
    }

}
