using UnityEngine;
using System.Collections;

public class touchControllerFB : MonoBehaviour {
	
	
	GameObject baseObject;
	string obj_name;
	// Use this for initialization
	void Start () {
		
		obj_name 			= this.gameObject.name + "Base";
		baseObject 			= GameObject.Find( obj_name );
		
		
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnMouseDown(){
		
		Debug.Log("OMD "+obj_name);
		Application.OpenURL("twitter:///user?screen_name=WeAreMadeReal");
		
		
	}
	
}