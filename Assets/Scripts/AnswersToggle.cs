using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class AnswersToggle : MonoBehaviour {

	ReadScript rs;
	GameObject answers;
 	// Use this for initialization
	void Start () {
		rs = GetComponent<ReadScript> ();
		answers = GameObject.Find ("Answers");
	}
	
	// Update is called once per frame
	void Update () { 
	}
	public void UpdateOnToggle(bool ev){
		//Comprueba si la respuesta es correctas
 		rs.contPreg ++;

	}
	private void ClearToggles(){
		ToggleGroup tg =answers.GetComponent<ToggleGroup> ();
		tg.SetAllTogglesOff ();
	}
}
