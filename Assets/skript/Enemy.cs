using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

	public float forceRight;
	public float forceLeft;
	public float speed;
	private Vector3 way;
	public GameObject jump;
	public GameObject jump1;
	public GameObject jump2;
	// Use this for initialization
	void Start () {
		way = Vector2.right;
	}
	
	// Update is called once per frame
	void Update () {
		transform.position += way * speed;
	}

	void OnTriggerEnter2D (Collider2D col) {
		if (gameObject.tag == "jump") {
			if (col.gameObject.name == "jump") {
				gameObject.GetComponent<Rigidbody2D> ().AddForce (new Vector2 (1, 1) * forceRight, ForceMode2D.Impulse);
			}
			if (col.gameObject.name == "jump1") {
				gameObject.GetComponent<Rigidbody2D> ().AddForce (new Vector2 (-1, 1) * forceLeft, ForceMode2D.Impulse);
			}
			if (col.gameObject.name == "jump2") {
				way = Vector2.right;
				jump.SetActive (false);
				jump1.SetActive (true);

			}
			if (col.gameObject.name == "jump3") {
				way = Vector2.left;
				jump.SetActive (true);
				jump1.SetActive (false);
				jump2.SetActive (true);
			}
		}
			if (col.gameObject.name == "jump2") {
				way = Vector2.right;

			}
			if (col.gameObject.name == "jump3") {
				way = Vector2.left;
		}
	}
}
