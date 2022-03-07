using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rajat : MonoBehaviour
{
  
    void Start()
    {
        
    } // start loppuu

    
    void Update()
    {
        // rajojen laittaminen
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -8.3f, 8.3f),
            Mathf.Clamp(transform.position.y, -6f, 6f), transform.position.z);
    } // update loppuu
} // class loppuu
