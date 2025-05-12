using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;

public class Esercizio_1 : MonoBehaviour
{
    public int index;
    public int num;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


        CicloWhile();
        
    }
    private void CicloWhile()
    {
        while(index > 0)
        {
            Debug.Log(num);
            
            num++;
            index--;

           
        }
    }
    
}
