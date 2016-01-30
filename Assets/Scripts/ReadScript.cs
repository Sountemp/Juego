using UnityEngine;
using System.Collections;
using SimpleJSON;

public class ReadScript : MonoBehaviour {

	public TextAsset jsonFile;

	private string escena;
	JSONNode N;
	// Use this for initialization
	void Start()
	{
		N = JSONNode.Parse (jsonFile.text);
	}

	// Update is called once per frame
	void Update()
	{
		string a = N ["Mensajes"] [0] ["Personaje"];
		Debug.Log (N["Mensajes"].Count);
 		GetPersonaje ();

	}
	public void GetPersonaje(){
		for (int i = 0; i < N ["Mensajes"].Count; i++) {
			if (N ["Mensajes"] [i] == "Personaje") {
				Debug.Log (N ["Mensajes"] [i]);
			}
		}
	}
}
