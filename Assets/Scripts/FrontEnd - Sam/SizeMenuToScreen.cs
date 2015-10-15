using UnityEngine;
using System.Collections;

public class SizeMenuToScreen : MonoBehaviour {

	RectTransform thisRect;

	// Use this for initialization
	void Start () {
		thisRect = transform.GetComponent<RectTransform> ();
		thisRect.sizeDelta = new Vector2 ((float)Screen.width*.666f, (float)Screen.height);
		thisRect.position = new Vector2 ((thisRect.rect.width / 2) - 1, thisRect.position.y);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
