using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerClassController : MonoBehaviour
{

    private PlayerClass player1;
    private PlayerClass player2;

    // Start is called before the first frame update
    void Start()
    {
       
        player1 = new PlayerClass();
        player1.punteggio = 15;
        player1.name = "Piero";
        player1.Stampa();

        player2 = new PlayerClass();
        player2.punteggio = 5;
        player2.name = "Kakarot";
        player2.Stampa();

    }

}
