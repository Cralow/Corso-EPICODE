using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySwitchBehaviour : MonoBehaviour
{

    public STATE st;
    public enum STATE 
    {
        IDLE,
        AGGROED,
        ATTACKING,
        DEFEATED
    }
    

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (st.Equals(STATE.IDLE))
            print("IDLE");
        if (st.Equals(STATE.AGGROED))
            print("AGGROED");
        if (st.Equals(STATE.ATTACKING))
            print("ATTACKING");
        if (st.Equals(STATE.DEFEATED))
            print("DEFEATED");

    }
}
