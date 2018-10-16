using UnityEngine;
using System.Collections;
using UnityEditor.SceneManagement;

public class playerContrl : MonoBehaviour {

	private Rigidbody2D rb;
	public float speed, jump_force;
	private bool grounded;
	public Transform respawn;
	// Use this for initialization
	void Start () {
		rb = gameObject.GetComponent<Rigidbody2D> ();
	}


	// Update is called once per frame
	void Update () {
		if ((Input.GetKeyDown (KeyCode.W) || 
			Input.GetKeyDown (KeyCode.UpArrow)) && grounded) {
			Jump ();
			transform.SetParent (null);
			}
		float fall;
	}

	void FixedUpdate () {
		rb.velocity = new Vector2 (Input.GetAxis ("Horizontal") * speed, rb.velocity.y);
	}

	void Jump () {
		rb.AddForce (transform.up * jump_force, ForceMode2D.Impulse);
		grounded = false;
	}
	void OnCollisionEnter2D (Collision2D collider) {
		if (collider.gameObject.name == "platform") {
			grounded = true;
			transform.SetParent (collider.gameObject.transform);
		}
		if (collider.gameObject.name == "Enemy") {
			transform.position = respawn.position;
		}
	}

	void OnTriggerEnter2D (Collider2D col) {
	if  (col.gameObject.name == "DeathArea")
	     	transform.position = respawn.position;
		if (col.gameObject.name == "win") {
			Debug.Log ("Вы победили");
			Application.LoadLevel ("lvl2");
		}
		if (col.gameObject.name == "speed") {
			speed += 2;
			Destroy (col.gameObject);
		}
	}
}
