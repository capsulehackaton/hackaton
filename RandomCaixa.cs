using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomCaixa : MonoBehaviour {
    public string letraatual;
    public string[] letras;
    public Sprite[] sprtletras;
    public SpriteRenderer letravis;
    public int arcontrole;
	// Use this for initialization
	void Start () {
       arcontrole=Random.Range(0,letras.Length);
        letraatual = letras[arcontrole];
        letravis.sprite = sprtletras[arcontrole];
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
