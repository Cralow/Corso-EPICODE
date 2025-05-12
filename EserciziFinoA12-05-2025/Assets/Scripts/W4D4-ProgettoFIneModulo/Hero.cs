
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Hero : MonoBehaviour
{
    [SerializeField]
    private string name;
    [SerializeField]
    private int hp;
    [SerializeField]
    private Stats baseStats;
    [SerializeField]
    private Weapon weapon;
    [SerializeField]
    private ELEMENT resistence;
    [SerializeField]
    private ELEMENT weakness;



  public Hero(string name, int hp,Weapon weapon, Stats baseStats, ELEMENT resistence, ELEMENT weakness)
    {
        this.name = name;
        this.hp = hp;
        this.weapon = weapon;
        this.baseStats = baseStats;
        this.resistence = resistence;
        this.weakness = weakness;

    }
    public string GetName()
    {
        return name;
    }

    public void SetName(string name)
    {
        this.name = name;   
    }
    public int GetHp()
    {
        IsAlive();
        return hp;
    }
    public void SetHp(int hp)
    {
        this.hp = hp;
    }

    public void AddHP(int amount) {
        SetHp(hp += amount); }

    public void TakeDamage(int damage)
    {
        SetHp(hp -= damage);
    }

    public Weapon GetWeapon()
    {
        return weapon;
    }
    public void SetWeapon(Weapon weapon)
    {
      this .weapon = weapon;    
    }

    public Stats GetBaseStats()
    {
        return baseStats;
    }
    public void SetBaseStats(Stats baseStats)
    {
        this.baseStats = baseStats;
    }
    public ELEMENT GetResistence()
    {
        return resistence;
    }
    public void SetResistence(ELEMENT resistance)
    {
        this.resistence = resistance;

    }
    public ELEMENT GetWeakness() { 
        return weakness;
    }
    public void SetWeakness(ELEMENT weakneass)
    {
        this.weakness = weakneass;

    }


    [SerializeField]
    public Boolean IsAlive()
    {
        if (this.hp > 0)
        {
            return true;

        }
        else
        {
            return false;
        }

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
        return baseStats;
    }



}
