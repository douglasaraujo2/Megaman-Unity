using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjetilScript : MonoBehaviour {

	public float velocidade;

	// Use this for initialization
	void Start () {
		//Destroi caso o projetil nao acerte nada
		Destroy (gameObject, 3.0f);
	}

	void OnCollisonEnter2D(Collision2D c){
		Destroy (gameObject);
	}

	
	// Update is called once per frame
	void Update () {
		//Mover o projetil
		transform.Translate (Vector2.right * velocidade * Time.deltaTime);
	}
}
