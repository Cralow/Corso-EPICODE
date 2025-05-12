using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using Unity.VisualScripting;
using UnityEngine;

public static class GameFormulas
{
    public static Boolean HasElementAdvantage(Enum n, Hero defender)
    {

        //String enumeratorToString = n.ToString();
        //String heroToString = Hero.ELEMENT.weakness.ToString();

        //if(enumeratorToString == heroToString)
        //{
        //    return true;
        //}
        //else
        //{
        //    return false;
        //}


        Hero.ELEMENT heroElement = defender.GetWeakness();
         string element = heroElement.ToString();

        if (element == n.ToString())
        {
            return true;
        }
        else
        {
            return false;
        }




   
    }

    public static Boolean HasElementDisadvantage(Enum ae, Hero defender)
    {


        Hero.ELEMENT heroElement = defender.GetResistence();
        string element = heroElement.ToString();

        if (element == ae.ToString())
        {
            return true;
        }
        else
        {
            return false;
        }

    }

    public static float EvaluateModifier(Enum atkElement,Hero defender)
    {
        if (HasElementAdvantage((Enum)atkElement, defender))
            return 1.5f;
        else if (HasElementDisadvantage((Enum)atkElement, defender))
            return 0.5f;
        else
        {
            return 1;
        }
    }
    public static Boolean HasHit(Stats attacker,Stats defender)
    {

    int HitChance = attacker.aim - defender.eva;

        int rn = UnityEngine.Random.Range(0, 100);
       
        if(HitChance > rn ) {
            Debug.Log("Miss");
            return false;
        }
        else
        {
            return true;

        }
        
    }
    public static Boolean IsCrit(int critValue)
    {


        int rn = UnityEngine.Random.Range(0, 100);

        if(rn > critValue)
        {
            Debug.Log("Crit");
            return true;
        }
        else
        {
            return false;
        }

    }

    public static int CalculateDamage(Hero attacker, Hero defender)
    {
        //somma stats
        Stats atk = attacker.GetBaseStats();
        Weapon atkWeapon = attacker.GetWeapon();
        Stats Wstats = atkWeapon.GetStats();
        Stats combinedStats = Stats.Sum(atk, Wstats);
        attacker.SetBaseStats(combinedStats);

        Stats defStats = defender.GetBaseStats();
        Weapon defWeapon = defender.GetWeapon();
        Stats DStats = defWeapon.GetStats();
        Stats DefCombined = Stats.Sum(defStats, DStats);
        defender.SetBaseStats(DefCombined);
        //seleziona difesa


        float difesa=0;
        if (atkWeapon.GetDAMAGE_TYPE() == Weapon.DAMAGE_TYPE.PHYSICAL)
        {
             difesa = DefCombined.def;
        }
        if (atkWeapon.GetDAMAGE_TYPE() == Weapon.DAMAGE_TYPE.MAGICAL)
        {
             difesa =  DefCombined.res;
        }

        //calcola danno base
        int dannoBase = combinedStats.atk - (int)difesa;

        dannoBase *= (int)EvaluateModifier(atkWeapon.GetDAMAGE_TYPE(), defender);







        bool critical = IsCrit((int)dannoBase);
        if (critical)
        {
            dannoBase = dannoBase * 2;
        }
        else
        {
            Debug.Log("no crit ");
        }


        if (dannoBase > 0)
        {
            return (int)dannoBase;
        }
        else
        {
            return 0;
        }
           

    }












}
