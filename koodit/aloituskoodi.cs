using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class aloituskoodi : MonoBehaviour
{
    
    void Start()
    {
        
    } //start loppu

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            SceneManager.LoadScene(1);
        }
    } // update loppu
} //class loppu
