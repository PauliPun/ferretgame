using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class namit_pallot : MonoBehaviour
{

    public float namit = 0f; //namien m‰‰r‰
    public float pallot = 0f; //namien m‰‰r‰

    // tekstikenttien haku
    private GameObject t1 = null;
    private GameObject t2 = null;

    void Start()
    {
        this.t1 = GameObject.Find("namit");
        this.t2 = GameObject.Find("palloja");
    } // start loppuu

    // Update is called once per frame
    void Update()
    {
        this.t1.GetComponent<Text>().text = "Namit: " + this.namit.ToString("0");
        this.t2.GetComponent<Text>().text = "Pallo-osumia: " + this.pallot.ToString("0");



        //Game overiin siirtyminen, 5 palloa, namit lasketaan 
        if (this.pallot == 5)
        {
            PlayerPrefs.SetFloat("namit", this.namit);
            Invoke("GameOver",1f);
        }
    } // update loppuu

    void GameOver()
    {
        SceneManager.LoadScene("gameover");
    }
} // class loppuu
