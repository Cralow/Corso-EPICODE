using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instatiate_sphere : MonoBehaviour
{
    public Transform sphere;
    public Vector3 posizioneDiSpawn = new Vector3(0f, 17f, 0f);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void DajeTutta()
    {
        Instantiate(sphere, posizioneDiSpawn, Quaternion.identity);    
    }
}
