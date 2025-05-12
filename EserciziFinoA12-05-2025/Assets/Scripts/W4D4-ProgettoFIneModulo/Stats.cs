using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Media;
using UnityEngine;

[Serializable]
public struct Stats 
{
    [SerializeField]
    public int atk;//0
    [SerializeField]
    public int def;
    [SerializeField]
    public int res;
    [SerializeField]
    public int spd;
    [SerializeField]
    public int crt;
    [SerializeField]
    public int aim;
    [SerializeField]
    public int eva;//6



    public Stats(int atk, int def, int res, int spd, int crt, int aim, int eva)
    {
        this.atk = atk;
        this.def = def;
        this.res = res;
        this.spd = spd;
        this.crt = crt;
        this.aim = aim;
        this.eva = eva;
            
    }



   // [SerializeField]
    public static Stats Sum(Stats stat1, Stats stat2)
    {
        Stats st = new Stats();

        st.atk = stat1.atk + stat2.atk;
        st.def = stat1.def + stat2.def;
        st.res = stat1.res + stat2.res;
        st.spd = stat1.spd + stat2.spd;
        st.crt = stat1.crt + stat2.crt;
        st.aim = stat1.aim + stat2.aim;
        st.eva = stat1.eva + stat2.eva;

        return new Stats(st.atk, st.def, st.res, st.spd, st.crt, st.aim, st.eva);
    }



}
