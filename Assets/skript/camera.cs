using UnityEngine;
using System.Collections;

public class camera : MonoBehaviour {
	
	public Transform target;
	public float smooth_speed;

	void FixedUpdate () {

		float desired_position_x = target.position.x;
		float desired_position_y = target.position.y;
		Vector3 smoothed_position = Vector3.Lerp (transform.position, new Vector3(desired_position_x, desired_position_y, transform.position.z), smooth_speed);
		transform.position = smoothed_position;
	}
}
