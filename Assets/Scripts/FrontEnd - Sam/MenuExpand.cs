using UnityEngine;
using System.Collections;

public class MenuExpand : MonoBehaviour {
	public GameObject sidePanel;
	public GameObject screen;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void setPanelActive(){
		print ("Here");
		sidePanel.SetActive (!sidePanel.activeInHierarchy);
		screen.SetActive (!screen.activeInHierarchy);
	}
}
