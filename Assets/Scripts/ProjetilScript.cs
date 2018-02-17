using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjetilScript : MonoBehaviour {

    public float velocidade;
    
	void Start () {
        // Destroi caso o projetil nao acerte nada
        Destroy(gameObject, 3.0f);	
	}

    void OnCollisionEnter2D(Collision2D c){
        // Destroi o projetil por colisao
        Destroy(gameObject);
    }

    void Update () {
        // Mover o projetil
        transform.Translate(Vector2.right * velocidade * Time.deltaTime);
	}
}
