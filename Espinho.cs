using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Espinho : MonoBehaviour {

	private Rigidbody2D espinhoRb;
	private int atrito;
	public int atritoMinimo, atritoMaximo;
	public Vector3 posicao;
	public GameObject espinhoPrefab;

	// Use this for initialization
	void Start () {
		espinhoRb = GetComponent<Rigidbody2D> ();
		atrito = Random.Range (atritoMinimo, atritoMaximo);
		espinhoRb.drag = atrito;

		posicao = transform.position;
	}
	
	void OnBecameInvisible(){
		Instantiate (espinhoPrefab, posicao, transform.localRotation);
		Pontuacao.pontos += 1;	
		Destroy(this.gameObject);
		
	}
}
