using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Blink : MonoBehaviour {
	public float intervalo;
	IEnumerator Start () {
		GetComponent<SpriteRenderer> ().enabled = false;
		yield return new WaitForSeconds (intervalo);
		GetComponent<SpriteRenderer> ().enabled = true;
		yield return new WaitForSeconds (intervalo);
		StartCoroutine (Start ());
	}
	void Update(){
		if (Input.GetKeyDown(KeyCode.Return)) {
			SceneManager.LoadScene ("GameScene");
		}
	}

}
