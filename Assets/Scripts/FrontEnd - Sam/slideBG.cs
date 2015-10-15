using UnityEngine;
using System.Collections;
using System;

public class slideBG : MonoBehaviour
{

	//Variables to trigger movement
	bool isMoving = false;
	bool isShowing = false;
	bool isActive = false;
	bool normalclose = true;

	//Variables affecting easing
	double openDur = 18;
	double closeDur = 10;
	double moveTime = 0;
	double moveDist;
	float startX;
	float initialStartX;

	int screenCount = 0;


	//Variables to store 2D object transform
	RectTransform thisRect;
	public RectTransform panelToExpose;
	public GameObject closeButton;

	enum menuScreen
	{
		Home,
		Settings,
		Something,
		Somewhere
	};

	menuScreen currScreen;// = menuScreen.Home;
	menuScreen prevScreen;
	//menuScreen prevScreen = (menuScreen)Enum.Parse (typeof(menuScreen), currScreen.ToString);
	// Use this for initialization
	void Start ()
	{
		//Set prevScreen to currScreen
		currScreen = menuScreen.Home;
		prevScreen = currScreen;

		//Reference to this object's rectTransform
		thisRect = transform.GetComponent<RectTransform> ();

		//get initial position of bgPanel
		initialStartX = thisRect.position.x;

		//Set move distance based on menuPanel, so that we can resize menu panel in 
		//inspector and moveDist will adapt automatically
		moveDist = panelToExpose.rect.width - 1;

	}
	
	// Fixed update so that easing occurs at a rate that is not tied to framerate speed
	void FixedUpdate ()
	{
		//Counting how long user has been on current screen
		if (currScreen == prevScreen) {
			screenCount ++;
		} else {
			print ("hey");
		}

		if (isMoving) {
			if (!isShowing) {


				//Opening
				if (moveTime < openDur) {
					//Easing takes args time, start, change duration
					thisRect.position = new Vector2 ((float)Easing.CircEaseOut (moveTime, startX, moveDist, openDur), thisRect.position.y);//.center.y + thisRect.rect.height /2 );//, thisRect.rect.width,thisRect.rect.height);
					moveTime += 1;
				}
				//Finish opening, reset timer and flip position bools
				else {
					moveTime = 0;
					isShowing = true;
					isMoving = false;
				}
			} else if (isShowing) {


				//If closing after menu finished opening
				if (normalclose) {
					if (moveTime < closeDur) {
						thisRect.position = new Vector2 ((float)Easing.CubicEaseOut (moveTime, startX, -1 * (moveDist), closeDur), thisRect.position.y);
						moveTime += 1;
					} else {
						moveTime = 0;
						isShowing = false;
						isMoving = false;
						closeButton.SetActive (false);
					}
				} else if (!normalclose) {


					//if re-closed while menu is still opening 
					if (moveTime < closeDur) {
						thisRect.position = new Vector2 ((float)Easing.CubicEaseOut (moveTime, startX, initialStartX - startX, closeDur), thisRect.position.y);
						moveTime += 1;
					} else {
						moveTime = 0;
						isShowing = false;
						isMoving = false;
						closeButton.SetActive (false);
					}
				}

			}
		}
		prevScreen = currScreen;
	
	}

	//Called from hamburger button
	public void triggerPanel ()
	{	
		//opening from fully closed
		if (!isMoving && !isShowing) {
			startX = thisRect.position.x;
			isMoving = true;
			closeButton.SetActive (true);
		} 
		//Closing while in the process of opening
		else if (isMoving && !isShowing) {
			startX = thisRect.position.x;
			closeButton.SetActive (false);
			isShowing = true;
			normalclose = false;
			moveTime = 0;
			print ("clicked while opening");
		}
		//Closing from fully open
		else if (!isMoving && isShowing) {
			startX = thisRect.position.x;
			isMoving = true;

		} 

	}

	public void triggerChangeMenu(string menuName){
		//Fade out current menu content and fade in new content based on string arg as menu closes
		//print ("Triggered switch to " + menuName);
		//print (currScreen.ToString ());
		transform.FindChild (currScreen.ToString ()).gameObject.SetActive (false);
		currScreen = (menuScreen)Enum.Parse (typeof(menuScreen), menuName);
		transform.FindChild (currScreen.ToString ()).gameObject.SetActive (true);

		//opening from fully closed
		if (!isMoving && !isShowing) {
			startX = thisRect.position.x;
			isMoving = true;
			closeButton.SetActive (true);
		} 
		//Closing while in the process of opening
		else if (isMoving && !isShowing) {
			startX = thisRect.position.x;
			closeButton.SetActive (false);
			isShowing = true;
			normalclose = false;
			moveTime = 0;
			print ("clicked while opening");
		}
		//Closing from fully open
		else if (!isMoving && isShowing) {
			startX = thisRect.position.x;
			isMoving = true;
			
		} 

	}

}
