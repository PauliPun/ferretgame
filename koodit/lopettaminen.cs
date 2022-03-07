using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lopettaminen : MonoBehaviour
{
 
    void Start()
    {
        
    } // start loppu


    void Update()
    {
        // pelin suorittaminen lopetetaan esc näppäimellä
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            Application.Quit();
        }
    } //update loppu
} // class loppu
