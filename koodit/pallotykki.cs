using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pallotykki : MonoBehaviour
{
    //namien prefab
    public GameObject pallo = null;

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
        if (this.ajastin >= 5f)
        {
            GameObject apunami = Instantiate(this.pallo,
                new Vector3(12f, -3f, 0f),
                Quaternion.identity);
            this.ajastin = 0f;
        }


    } // update loppu
} // class loppu
