using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class SplashScreenFade : MonoBehaviour {
	Image panel;
	Image childImage;
	int count;
	public int fadeDur;
	// Use this for initialization
	void Start () {
		panel = transform.GetComponent<Image> ();
		childImage = transform.GetComponentInChildren<Image> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
