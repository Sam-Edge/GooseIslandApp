using UnityEngine;
using System.Collections;

public class touchControllerWeb : MonoBehaviour {


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
		Application.OpenURL("http://wearemadereal.com/");
		
	
	}

}