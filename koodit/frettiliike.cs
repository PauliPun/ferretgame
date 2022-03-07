using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class frettiliike : MonoBehaviour
{
    public float liikeNopeus = 1f; //liikkeen nopeus
    private float voima = 30000f; // hypyn voima
    private bool ilmassa = false; //vain maasta hyppääminen

    void Start()
    {
        
    } //start loppuu

    
    void Update()
    {

        // nuolinäppäimillä liikkuminen ja fretin kääntyminen
        var liike = Input.GetAxis("Horizontal");
        transform.position += new Vector3(liike, 0,0) * Time.deltaTime * liikeNopeus;
        if (liike > 0f)
        {
            transform.localScale = new Vector2(-0.6376573f, 0.6498569f);
        }
        else if (liike < 0f)
        {
            transform.localScale = new Vector2(0.6376573f, 0.6498569f);
        }

        // liikeen tunnistaminen
        if (Mathf.Abs(liike) > 0.05f)
        {
            this.GetComponent<Animator>().SetInteger("juokseeko", 1);
        }
        else
        {
            this.GetComponent<Animator>().SetInteger("juokseeko", 0);
        }

        // hyppy
        if (Input.GetKeyDown(KeyCode.Space) && (!this.ilmassa))
        {
            this.GetComponent<Rigidbody2D>().AddForce(Vector2.up*this.voima);
            this.GetComponent<Animator>().SetInteger("onkoIlmassa", 2);
        }
        

    } //update loppuu

    //maassa
    void OnCollisionEnter2D(Collision2D toinen)
    {
        this.ilmassa = false;
        this.GetComponent<Animator>().SetInteger("onkoIlmassa", 1);
    }
    //ilmaan pompatessa
    void OnCollisionExit2D(Collision2D toinen)
    {
        this.ilmassa = true;
    }

} // class loppuu

