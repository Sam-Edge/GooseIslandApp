using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PanelSlide : MonoBehaviour
{

	bool isMoving = false;
	bool isShowing = false;
	bool isActive = false;

	double moveDur = 20;
	double movetime = 0;
	double moveDist; 

	RectTransform thisRect;
	float startX;

	// Use this for initialization
	void Start ()
	{
		thisRect = transform.GetComponent<RectTransform> ();
		thisRect.sizeDelta = new Vector2 ((float)(Screen.width / 2.5f), (float)Screen.height + 10);
		thisRect.position = new Vector2 ((float)0 - thisRect.rect.width / 2, thisRect.position.y);
	}
	
	// Update is called once per frame
	void FixedUpdate ()
	{
		if (isMoving) {// && !isShowing) {
			if (movetime < moveDur) {

				thisRect.position = new Vector2 ((float)Easing.CubicEaseOut (movetime, startX, thisRect.rect.width - 2, moveDur), thisRect.position.y);//.center.y + thisRect.rect.height /2 );//, thisRect.rect.width,thisRect.rect.height);
				movetime += 1; //Time.deltaTime;
			}
		}
	
	}

	void triggerPanel ()
	{
		print ("hi");
		if (!isMoving && !isShowing) {
			startX = thisRect.rect.x;
			isMoving = true;
		}
	}


}
