using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour {

	public float velocidade;
	public float impulso;

	public Transform chaoVerificador;
	bool estaoNoChao;

	SpriteRenderer spriteRender;
	Rigidbody2D rb;
    Animator animator;

	void Start () {
		// Interface para os componentes
		spriteRender = GetComponent<SpriteRenderer>();
		rb = GetComponent<Rigidbody2D> ();
        animator = GetComponent<Animator>();
	}

	void Update () {
		
		// Mover
		float mover_x = Input.GetAxisRaw("Horizontal") * velocidade * Time.deltaTime;
		transform.Translate (mover_x, 0.0f, 0.0f);

		// Verificar colisao com o piso
		estaoNoChao = Physics2D.Linecast(transform.position, 
			chaoVerificador.position, 1 << LayerMask.NameToLayer("Piso"));


		//print (estaoNoChao);


		// Pulo
		if (Input.GetButtonDown ("Jump") && estaoNoChao) {
			rb.velocity = new Vector2 (0.0f, impulso); 
		}

		// Orientacao
		if (mover_x > 0) {
			spriteRender.flipX = false; 
		} else if (mover_x < 0) {
			spriteRender.flipX = true; 
		}

        // Animacoes
        animator.SetFloat("pMover", Mathf.Abs(Input.GetAxisRaw("Horizontal")));
        animator.SetBool("pJump", !estaoNoChao); 
		animator.SetBool ("pFire", Input.GetButton ("Fire1"));
	}
}
