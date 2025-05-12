using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Experimental.GraphView.GraphView;

public class PlayerClass
{
    public string name;
    public int punteggio;
    public void Stampa()
    {

        Debug.Log("Arriva: " + name + " con un livello di: " + punteggio.ToString());
     
    }

}
