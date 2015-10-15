using UnityEngine;
using System.Collections;

public class HidePanel : MonoBehaviour {
	public GameObject sidePanel;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void setPanelActive(){
		print ("Here");
		if (sidePanel.activeInHierarchy == true) {
			sidePanel.SetActive (false);
			gameObject.SetActive (false);
		}
	}
}
