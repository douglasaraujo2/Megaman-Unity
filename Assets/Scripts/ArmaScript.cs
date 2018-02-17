using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmaScript : MonoBehaviour {

	public GameObject projetilPrefab;
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown ("Fire1")) {
			Instantiate (projetilPrefab,transform.position,transform.rotation);
		}
	}
}
