using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmaScript : MonoBehaviour {

    public GameObject projetilPrefab;
    public GameObject sensorRotacao;

	void Update () {

        // Fire 1 (CTRL Esquerdo, clique ou toque na tela)
        if (Input.GetButtonDown("Fire1")){
            Instantiate(projetilPrefab, transform.position, transform.rotation);
        }

        // Direcao da arma
        if (Input.GetAxisRaw("Horizontal") > 0.0f){
            sensorRotacao.transform.eulerAngles = new Vector3(0.0f, 0.0f, 0.0f); 
        }else if(Input.GetAxisRaw("Horizontal") < 0.0f){
            sensorRotacao.transform.eulerAngles = new Vector3(0.0f, 180.0f, 0.0f);
        }

	}
}
