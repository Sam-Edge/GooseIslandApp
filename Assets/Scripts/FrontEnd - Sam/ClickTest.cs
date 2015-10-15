using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class ClickTest : MonoBehaviour {
	Button thisButton;
	// Use this for initialization
	void Start () {
		thisButton = gameObject.GetComponent<Button> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void changeScene(){
		Application.LoadLevel ("ARMadeReal2");
	}

	void clickTested(){
		print ("Clicked!");
	}
}
