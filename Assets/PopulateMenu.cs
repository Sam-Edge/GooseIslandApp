using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class PopulateMenu : MonoBehaviour {

	public List<string> buttonTexts;
	public List<Sprite> menuIcons;
	public GameObject buttonPrefab;

	RectTransform thisRect;

	public Transform BGReference;

	// Use this for initialization
	void Start () {
		//Get rectTransform of this object
		thisRect = transform.GetComponent<RectTransform> ();

		for (int i = 0; i < buttonTexts.Count; i ++) {
			//Spawn button prefab
			GameObject tempObj = Instantiate (buttonPrefab) as GameObject;

			//Set button parent to this object 
			tempObj.transform.SetParent (transform);

			//Set up reference to buttons rectTransform
			RectTransform tempRect = tempObj.transform.GetComponent<RectTransform> ();

			//Resize, position and space out buttons
			tempRect.sizeDelta = new Vector2 (thisRect.rect.width, Screen.height / 7);
			tempRect.position = new Vector2 (thisRect.position.x, (((thisRect.position.y) + (thisRect.rect.height/2)) - (tempRect.rect.height / 2)) - (tempRect.rect.height * i));

			//Set buttons images and text based on list order
			Transform tempText = tempObj.transform.FindChild("Text");
			tempText.GetComponent<Text>().text = buttonTexts[i];

			tempObj.transform.FindChild("Image").GetComponent<Image>().sprite = menuIcons[i];
		}




	}

	//so first, create the list of let's say strings to represent menu buttons on menupanel, plus matching sprites
	//(let's go by order rather than name for the sprites perhaps for now)

	//Then, check and see if there are any content children of the main bg that have a matching name

	//For each matching name we create and link a button to that content, if no content with matching name is found,
	//We delete that button, or don't create it in the first place

	//Finally we order and size the buttons to the menuPanel

	//THEN I will write the code for the buttons to actually launch the different content

	// Update is called once per frame
	void Update () {
	
	}
}
