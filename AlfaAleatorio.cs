using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlfaAleatorio : MonoBehaviour {
    public string letra;//letra inicial
    public string[] alfaAleatorio;//array de letras possiveis
    public int valorcaixas;//quantidade de caixas que serao habilitdas
    public int[] qtletras;//array que determina a quantidade de caixas serao ativadas tem referencia a letras possiveis
    private int nrArray; // variavel de buffer para determinar igualmente valor de caixas e letra que sera usada
    public GameObject[] caixashab;//variavel que contem todas as caixas
    public Sprite[] spriteletra;
    public SpriteRenderer renderizar;
	// Use this for initialization
	void Start () {
        nrArray= Random.Range(0, alfaAleatorio.Length);// escolhe randomicamente a letra e a quantiade de caixas
        letra = alfaAleatorio[nrArray]; //determina a letra inicial do game
        valorcaixas = qtletras[nrArray];//determina a quantidade de caixas ativadas
        renderizar.sprite = spriteletra[nrArray]; 
        for (int i = 0; i < valorcaixas; i++)
        { 
            caixashab[i].SetActive(true);
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
