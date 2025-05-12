using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[Serializable]
public class Weapon : MonoBehaviour
{
    [SerializeField]
    private string name;
    [SerializeField]
    public DAMAGE_TYPE dmgType;
    [SerializeField]
    private ELEMENT elem;
    [SerializeField]
    private Stats bonusStats;


    public Weapon(string name, DAMAGE_TYPE dmgType, ELEMENT elem, Stats bonusStats)
    {
        this.name = name;
        this.dmgType = dmgType;
        this.elem = elem;
        this.bonusStats = bonusStats;
    }

    public enum DAMAGE_TYPE
    {
        PHYSICAL,
        MAGICAL
    }
    public enum ELEMENT
    {
        NONE,
        FIRE,
        ICE,
        LIGHTNING,

    }
    public Stats GetStats()
    {
        return bonusStats;
    }
    public void SetStats(Stats stats)
    {
        bonusStats = stats;
    }
    public ELEMENT GetElement()
    {
        return elem;

    }
    public void SetElement(ELEMENT element)
    {
        elem = element;
    }
    public DAMAGE_TYPE GetDAMAGE_TYPE()
    {
        return dmgType;
    }
    public string GetName()
    {
        return name;
    }
    public void SetName(string name)
    {
        this.name = name;
    }


}
