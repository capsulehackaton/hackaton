using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DepositaCaixa : MonoBehaviour {

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {

    }
    public void PegarLetra()
        {
            
        }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Caixa" && !FindObjectOfType<PlayerBehaviour>().grabCx)
        {
            string i=collision.gameObject.GetComponent<RandomCaixa>().letraatual;
        }
    }
}
