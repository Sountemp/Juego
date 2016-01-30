using UnityEngine;
using System.Collections;
using SimpleJSON;
using UnityEngine.UI;

public class ReadScript : MonoBehaviour {

	public TextAsset jsonFile;
	private string personaje;
	private string mensaje;
	private JSONArray respuestaJSON;
	private string[] respuesta;
	public int contPreg = 0;
	GameObject chatCyborg;
	GameObject chatPersonaje;
	GameObject[] respuestas;
	Text chatCyborgText;
	Text chatPersonajeText;

	JSONNode N;
 
	// Use this for initialization
	void Start()
	{
		contPreg = 0;
		N = JSONNode.Parse (jsonFile.text);
 		chatCyborg = GameObject.Find ("ChatBubble1");
		chatPersonaje = GameObject.Find ("ChatBubble2");
		chatCyborgText = chatCyborg.GetComponentInChildren<Text>();
		chatPersonajeText = chatPersonaje.GetComponentInChildren<Text> ();
		respuestas = GameObject.FindGameObjectsWithTag ("Answer");
		System.Array.Reverse (respuestas);
	}

	// Update is called once per frame
	void Update()
	{
		//read mensaje
		//quien lo envia?
		//activar burbuja
		//print texto
		GetPersonaje ();
		GetMensaje ();
		GetRespuestas ();
	}

	public void GetPersonaje(){
		
		if (N ["Mensajes"] [contPreg] ["Personaje"] != null) {
			//devuelve el nombre del personaje de cada texto
			personaje = N ["Mensajes"] [contPreg] ["Personaje"];
			if (personaje == "cyborg") {
				chatPersonaje.gameObject.SetActive(false);
				chatCyborg.gameObject.SetActive(true);
				print ("cyborg hablando");
			} else {
				chatPersonaje.gameObject.SetActive(true);
				chatCyborg.gameObject.SetActive(false);
				print ("elotro hablando");
			}
		}

	}  

	public void GetMensaje(){
	 
		if (N ["Mensajes"] [contPreg] ["Texto"] != null) {
			//devuelve el texto
			//en la burbuja del personaje que esta hablando
			mensaje = N ["Mensajes"] [contPreg] ["Texto"];
			print (personaje);
			if (personaje == "cyborg") {
				chatCyborgText.text = mensaje;
 				print ("mensaje cyborg");
			} else {
				chatPersonajeText.text = mensaje;
 				print ("mensaje elotro");
			}	
		}
	 
	}

	public void GetRespuestas(){
		
		if (N ["Mensajes"] [contPreg] ["Respuestas"] != null) {
			//devuelve las posibles respuestas
			respuestaJSON = N ["Mensajes"] [contPreg] ["Respuestas"].AsArray;
			print (respuestaJSON.ToString());
			for(int i = 0;i < respuestas.Length; i++){
				print(respuestaJSON[i]);
				respuestas [i].GetComponentInChildren<Text> ().text = respuestaJSON[i]["Texto"];
			}
		}

	}
}
