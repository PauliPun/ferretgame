using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class gameoverkoodi : MonoBehaviour
{
    
    void Start()
    {
        float namimaara = PlayerPrefs.GetFloat("namit");
        GameObject.Find("namityhteensa").GetComponent<Text>().text = "Keräsit nameja yhteensä "
                                                             + namimaara.ToString("0") + " kpl";
    } // start loppuu

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            SceneManager.LoadScene(1);
        }
    } // update loppuu
} // class loppuu
