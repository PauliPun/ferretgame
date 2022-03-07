using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pallokoodi : MonoBehaviour
{

    private float pallonNopeus = 0;
    public GameObject savu = null;

    void Start()
    {
        this.pallonNopeus = Random.Range(3f, 8f); //palloilla random nopeus
    } // start loppu

    
    void Update()
    {
        //pallon lenn‰tt‰minen
        this.GetComponent<Transform>().Translate(-this.pallonNopeus * Time.deltaTime, 0f,0f);

        //pallon tuhoaminen jos se menee reunan yli
        if (this.GetComponent<Transform>().position.x < -12f)
        {
            Destroy(this.gameObject);
        }
        
    } //update loppu

    void OnTriggerEnter2D(Collider2D tormaaja)
    {
        if (tormaaja.name.Equals("frettisprite"))
        {
            //tˆrmayksen ‰‰ni
            GameObject.Find("sounds").GetComponents<AudioSource>()[0].Play();
            //savua kun palloon osuu
            GameObject apusavu = Instantiate(this.savu,
                                             this.GetComponent<Transform>().position,
                                             Quaternion.identity);
            // savun poistaminen
            Destroy(apusavu.gameObject, 1f);
            GameObject.Find("koodeja").GetComponent<namit_pallot>().pallot += 1f; //pallojen lis‰‰minen
            Destroy(this.gameObject);
        }
    }
} // class loppu
