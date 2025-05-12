using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageTypeExample : MonoBehaviour
{

    public DAMAGE_TYPE attackType;
    public DAMAGE_TYPE resistence;
    public DAMAGE_TYPE weakness;

    public int baseDamage;
    public enum DAMAGE_TYPE
    {
        SLASHING = 10,
        PIERCING = 7,
        BLUDGEOING = 6,
        MAGICAL = 5,
        FORCE = 4
    }
    

    void Start()
    {
        if(attackType == resistence)
        {
            baseDamage = baseDamage / 2;
            Debug.Log("Danno dimezzato");
        }
        if (attackType == weakness)
        {
            baseDamage = baseDamage * 2;
            Debug.Log("Danno critico");
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
