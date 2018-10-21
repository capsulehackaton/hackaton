using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour {
    public bool grabCx;
    public bool podGrabCx;
    private bool tuklik;
	// Use this for initialization
	void Start () {
        grabCx = false;
        podGrabCx = false;
        tuklik = false;
	}
	
	// Update is called once per frame
	void Update ()
    {

	}
    public void GrabIten()
    {
        if (podGrabCx && !tuklik)
        {
            grabCx = true;
            tuklik = true;
        }
        else
        {
            if (tuklik)
            {
                grabCx = false;
                tuklik = false;
                podGrabCx = false;
            }
        }
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "ptsupcx" && !grabCx)
        {
            podGrabCx = false;
        }
        if (collision.gameObject.tag == "Caixa")
        {
            podGrabCx = true;
        }

    }
}
