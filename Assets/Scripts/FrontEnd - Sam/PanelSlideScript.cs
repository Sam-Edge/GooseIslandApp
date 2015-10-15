using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PanelSlideScript : MonoBehaviour
{
	public GameObject panelObj;
	Image panel;
	public bool panelIsMoving = false;
	public bool panelOnScreen = false;
	float moveDur = 50;
	float moveTime = 0;
	float savedStartPos;

	// Use this for initialization
	void Start ()
	{
		panel = panelObj.GetComponent<Image> ();
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (panelIsMoving) {
			if (!panelOnScreen) {
				if (moveTime < moveDur) { //movetime: how far are you through movement. Start value, change in value, time
					panel.rectTransform.position = new Vector2 ((float)Easing.CircEaseInOut ((double)moveTime, (double)savedStartPos, (double)-166, (double)moveDur), panel.rectTransform.position.y);
					moveTime ++;
				} else {
					panelOnScreen = true;
					panelIsMoving = false;
					moveTime = 0;
				}
			} else {
				if (moveTime < moveDur) {
					panel.rectTransform.position = new Vector2 ((float)Easing.CircEaseInOut ((double)moveTime, (double)savedStartPos, (double)166, (double)moveDur), panel.rectTransform.position.y);
					moveTime ++;
				} else {
					panelOnScreen = false;
					panelIsMoving = false;
					moveTime = 0;
				}
			}
		}
	}

	void movePanel ()
	{
		if (!panelIsMoving) {
			panelIsMoving = true;
			savedStartPos = panel.rectTransform.position.x;
		}
	}
}



