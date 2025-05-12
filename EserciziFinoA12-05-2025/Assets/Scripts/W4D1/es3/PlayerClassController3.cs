using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerClassController3 : MonoBehaviour
{

    private PlayerClass3 player1;


    // Start is called before the first frame update
    void Start()
    {
       
        player1 = new PlayerClass3();
        player1.GetPunteggio();
        player1.name = "Piero";
        player1.Stampa();


        player1.IncrementaPunteggio();

        player1.SetPunteggio(player1.GetPunteggio());

    }

}
