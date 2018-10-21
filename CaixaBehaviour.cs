using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaixaBehaviour : MonoBehaviour {
    public Transform playerpos;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
        if (FindObjectOfType<PlayerBehaviour>().grabCx)
        {
            if(FindObjectOfType<PlayerBehaviour>().gameObject.transform.localScale.x<0)
            //if (PlayerPrefs.GetFloat("direcao") < 0)
            {
                transform.position = new Vector3(playerpos.transform.position.x - 1.5f, playerpos.transform.position.y, playerpos.transform.position.z);
            }
            else
            {
                if (FindObjectOfType<PlayerBehaviour>().gameObject.transform.localScale.x > 0)
                //if (PlayerPrefs.GetFloat("direcao") > 0)
                {
                    transform.position = new Vector3(playerpos.transform.position.x + 1.5f, playerpos.transform.position.y, playerpos.transform.position.z);
                }
            }
        }
	}
    public void OnTriggerEnter2D(Collider2D collision)
    {

    }
}
