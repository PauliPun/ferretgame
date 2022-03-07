using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class namikoodi : MonoBehaviour
{
    
    void Start()
    {
       
    } // startin loppu

    
    void Update()
    {
        //nami tuhotaan
        if (this.GetComponent<Transform>().position.y < -7f)
        {
            Destroy(this.gameObject);
        }

    } // updaten loppu

    //namin tuhoaminen kun sen saa kiinni
    void OnTriggerEnter2D(Collider2D tormaaja)
    {
        if (tormaaja.name.Equals("frettisprite"))
        {
            //syˆmisen ‰‰ni
            GameObject.Find("sounds").GetComponents<AudioSource>()[2].Play();
            GameObject.Find("koodeja").GetComponent<namit_pallot>().namit += 1f; //namien lis‰‰minen
            Destroy(this.gameObject);
        }
    }

} //classin loppu
