using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class namiMultiplier : MonoBehaviour
{
    //namien prefab
    public GameObject nami = null;

    //namien vauhti
    private float ajastin = 0f;
    
    void Start()
    {
        
    } // start loppu

    
    void Update()
    {
        // kirjanpitoa namien luonnin aikavälistä
        this.ajastin += Time.deltaTime;

        //namien luominen kun edellisestä on kulunut tietty aika
        if (this.ajastin >= 2f)
        {
            GameObject apunami = Instantiate(this.nami,
                new Vector3(Random.Range(-8.3f,8.3f), 5.5f, 0f),
                Quaternion.identity);
            this.ajastin = 0f;
        }

        
    } // update loppu
} // class loppu
