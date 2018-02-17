using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InimigoScript : MonoBehaviour {


	public int vidas;
	public GameObject peixePrefab;
	public Transform gerarPeixes;
	public float intervalo;


	// Use this for initialization
	IEnumerator Start () {

		//Gerar os peixes que sairam da boca do inimigo
		Instantiate (peixePrefab, gerarPeixes.position, gerarPeixes.rotation);
		yield return new WaitForSeconds (intervalo);
		StartCoroutine (Start());
	}
	
	void OnCollisionEnter2D(Collision2D c){
		if (c.gameObject.tag == "Projetil") {
			Destroy (c.gameObject);
			vidas--;
			if (vidas <= 0) {
				Destroy (gameObject);
			}
		}
	}
}
