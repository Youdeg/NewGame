using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour {
	
	public float hight;
	public float speed;

	Vector3 way;

	void Update () {
		
		float ani = Mathf.Sin (Time.time * speed) * hight;
		switch (gameObject.tag) {

		case "right":
			way = Vector2.right;
			break;
			
		case "left": 
			way = Vector2.left;
			break;
			
		case "up":
			way = Vector2.up;
			break;
			
		case "down":
			way = Vector2.down;
			break;

		}

		transform.position += way * ani;

	}
}
