using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	private static GameManager manager = null;
	public static GameManager Manager{
		get{ 
			return manager;
		}
	}

	ReadScript read;

	void Awake(){
		GetThisGameManager ();
	}
	// Use this for initialization
	void Start () {
		read = GetComponent<ReadScript> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void GetThisGameManager(){
		if (manager != null && manager != this) {
			Destroy (this.gameObject);
			return;
		} else {
			manager = this;
		}
		DontDestroyOnLoad (this.gameObject);
	}
}
