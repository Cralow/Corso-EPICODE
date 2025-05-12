using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class M1ProjectTest : MonoBehaviour
{
    public Hero a;
    public Hero b;

    private string nomeVincitore;
    private void Start()
    {
        a.SetBaseStats(Stats.Sum(a.GetBaseStats(), a.GetWeapon().GetStats()));
        b.SetBaseStats(Stats.Sum(b.GetBaseStats(), b.GetWeapon().GetStats()));
    }
    private void Update()
    {



        if(a.GetBaseStats().spd > b.GetBaseStats().spd)
        {

            if (a.IsAlive() == true && b.IsAlive() == true)
            {

                Debug.Log(a.GetName() + " Attacca " + b.GetName());
                Round(a, b);
                if (b.IsAlive() == false)
                {
                    Debug.Log("e vince : " + a.GetName());
                    return;
                }
                else
                {
                    Round(b, a);
                    return;
                }



            }
            else
            {
                return;
            }
        }
        if (a.GetBaseStats().spd < b.GetBaseStats().spd)
        {
            if (a.IsAlive() == true && b.IsAlive() == true)
            {
                Debug.Log(b.GetName() + " Attacca " + a.GetName());
                Round(b, a);
                if (a.IsAlive() == false)
                {
                    Debug.Log("e vince : " + b.GetName());
                }
                else
                {
                    Round(a,b);
                }



            }
            else
            {
                return;
            }
        }

        //controllo is alive

       

    }
    private void Round(Hero attacker, Hero defender)
    {

        Debug.Log(attacker.name+ " Attacca " + defender.name);
        bool attaccoSegno = GameFormulas.HasHit(attacker.GetStats(), defender.GetStats());

        if (attaccoSegno)
        {
            if (GameFormulas.HasElementAdvantage(attacker.GetWeapon().GetElement(), defender))
            {
                Debug.Log("WeakNess!");


            }
            if (GameFormulas.HasElementDisadvantage(attacker.GetWeapon().GetElement(), defender))
            {
                Debug.Log("Resist!");


            }
          int danno =  GameFormulas.CalculateDamage(attacker, defender);

            Debug.Log(danno.ToString()+" Danni inflitti ");

            defender.TakeDamage(danno);
          




        }
        else
        {
            Debug.Log(attacker.name + " Missa il suo attacco " + defender.name);
        }
    


    }











}
