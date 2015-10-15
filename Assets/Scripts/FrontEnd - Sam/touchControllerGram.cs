 using UnityEngine;
using System.Collections;


public class touchControllerGram : MonoBehaviour {

	GameObject baseObject;
	string obj_name;
	// Use this for initialization
	void Start () {
		
		obj_name 			= this.gameObject.name + "Base";
		baseObject 			= GameObject.Find( obj_name );
		GameObject.Find ("InstaPlane").GetComponent<Renderer>().enabled = false;
		GameObject.Find ("InstaAppBut").GetComponent<Renderer>().enabled = false;
		
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnMouseDown(){
		
		Debug.Log("OMD "+obj_name);

		if (GameObject.Find ("InstaPlane").GetComponent<Renderer>().enabled == false) {
			GameObject.Find ("InstaPlane").GetComponent<Renderer>().enabled = true;
			GameObject.Find ("InstaAppBut").GetComponent<Renderer>().enabled = true;
		} else {
			GameObject.Find ("InstaPlane").GetComponent<Renderer>().enabled = false;
			GameObject.Find ("InstaAppBut").GetComponent<Renderer>().enabled = false;
		}
		
	}
	
}