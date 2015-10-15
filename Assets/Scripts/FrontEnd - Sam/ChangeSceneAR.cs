using UnityEngine;
using System.Collections;

public class ChangeSceneAR : MonoBehaviour {


	public string levelToLoad = ""; 
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void changeSceneSetup(){
		if(true){
			changeScene(levelToLoad);
		}
	}

	void changeScene(string p){
		Application.LoadLevel (p);
	}
}
