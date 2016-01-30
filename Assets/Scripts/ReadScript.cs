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

	}

	public void GetPersonaje(){
		for (int i = 0; i < N ["Mensajes"].Count; i++) {
			if (N ["Mensajes"] [i] ["Personaje"] != null) {
					//devuelve el nombre del personaje de cada texto
			}
		}
	}

	public void GetMensaje(){
		for (int i = 0; i < N ["Mensajes"].Count; i++) {
			if (N ["Mensajes"] [i] ["Texto"] != null) {
				//devuelve el texto
			}
		}
	}

	public void GetRespuestas(){
		for (int i = 0; i < N ["Mensajes"]["Respuestas"].Count; i++) {
			if (N ["Mensajes"] [i] ["Respuestas"] != null) {
				//devuelve las posibles respuestas
			}
		}
	}
}
