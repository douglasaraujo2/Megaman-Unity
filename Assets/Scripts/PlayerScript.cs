using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour {

	public float velocidade;
	public float impulso;
	public Transform chaoVerificador;




	//Variaveis Locais
	Rigidbody2D rb;
	SpriteRenderer sprite;
	bool estaNoChao;
	// Use this for initialization
	void Start () {
		sprite = GetComponent<SpriteRenderer> ();
		rb = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown ("Jump") && estaNoChao) {
			rb.velocity = new Vector2 (0.0f, impulso);
		
		}
			
		float mover_x = Input.GetAxisRaw ("Horizontal") * velocidade * Time.deltaTime;
		transform.Translate (mover_x, 0.0f, 0.0f);
		if (mover_x > 0) {
			sprite.flipX = false;
		} else if (mover_x < 0) {
			sprite.flipX = true;
		}

		estaNoChao = Physics2D.Linecast (transform.position, chaoVerificador.position, 1 << LayerMask.NameToLayer ("Piso"));



	}
}
