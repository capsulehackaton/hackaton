using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControledeCaixas : MonoBehaviour {
    public string letra2; 
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Caixa" && FindObjectOfType<PlayerBehaviour>().grabCx)
        {
            letra2 = collision.gameObject.GetComponent<RandomCaixa>().letraatual;
        }
    }
}
