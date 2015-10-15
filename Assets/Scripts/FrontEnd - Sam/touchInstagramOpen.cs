using UnityEngine;
using System.Collections;

public class touchInstagramOpen : MonoBehaviour {

	GameObject baseObject;
	string obj_name;
	bool leftApp = false;
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
		Application.OpenURL("instagram://user?username=wearemadereal");
		//OpenFacebookPage ();

		}

	IEnumerator OpenFacebookPage(){
		
		Application.OpenURL("fb://page/838122829594762");
		yield return new WaitForSeconds(2);
		if(leftApp){
			leftApp = false;
					}
			else{
				Application.OpenURL("https://www.facebook.com/wearemadereal");
			}
		}
				
	void OnApplicationPause(){
		leftApp = true;
		}
	
}