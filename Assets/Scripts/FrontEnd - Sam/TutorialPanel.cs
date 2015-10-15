using UnityEngine;
using System.Collections;

public class TutorialPanel : MonoBehaviour {
	public GameObject tutorialPanel; //store a reference to the panel
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void openPanel(){
		//Code to Open Panel goes here
		tutorialPanel.SetActive (!tutorialPanel.activeInHierarchy);
	}
}
