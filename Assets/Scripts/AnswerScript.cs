using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class AnswerScript : MonoBehaviour {

	GameObject[] answersToggle;

	// Use this for initialization
	void Start () {
		answersToggle = GameObject.FindGameObjectsWithTag ("Answer");
		foreach (GameObject answer in answersToggle) {
			Debug.Log ("hey");
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
