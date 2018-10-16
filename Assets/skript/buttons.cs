using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEditor.SceneManagement;

public class buttons : MonoBehaviour {
	
	public Sprite first_state, second_state;
	bool flag;

	void OnMouseDown () {
		if (gameObject.name == "sound") {
			if (flag)
				gameObject.GetComponent<SpriteRenderer> ().sprite = first_state;
			else
				gameObject.GetComponent<SpriteRenderer> ().sprite = second_state;
			flag = !flag;
		} else 
			gameObject.GetComponent<SpriteRenderer> ().sprite = second_state;

	}

	void OnMouseUp () {

		if (gameObject.name != "sound")
			gameObject.GetComponent<SpriteRenderer> ().sprite = first_state;

	}

	void OnMouseUpAsButton () {

		switch (gameObject.name) {

		case "Play":
			EditorSceneManager.LoadScene ("pr");
			break;

		case "Rating":
			Application.OpenURL ("https://vk.com/dimas.ostapenko");
			break;

		}
	}
}
