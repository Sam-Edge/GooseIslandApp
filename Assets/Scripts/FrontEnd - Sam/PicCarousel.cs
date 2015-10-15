using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class PicCarousel : MonoBehaviour
{
	public GameObject imageHolder;
	public List<Sprite> SpritesForCarousel;
	int padding = 40;
	RectTransform panelRect;
	RectTransform imHolderRect;
	RectTransform parentRect;

	bool once = false;

	// Use this for initialization
	void Start ()
	{	
		//Uncomment this line to add sprites at runtime, make sure you call this line BEFORE trying to add sprites or you'll get an error
		//If you're having trouble adding something before this 'start' function runs, try using 'Awake()', which runs before start
		//SpritesForCarousel = new List<Sprite> ();
		panelRect = transform.GetComponent<RectTransform> ();
		imHolderRect = imageHolder.GetComponent<RectTransform> ();
		parentRect = transform.parent.GetComponent<RectTransform> ();
		panelRect.sizeDelta = new Vector2((imHolderRect.rect.width * SpritesForCarousel.Count) + (padding * SpritesForCarousel.Count + 1f), panelRect.sizeDelta.y);

		for (int i = 0; i < SpritesForCarousel.Count; i ++) {

			GameObject tempIm = Instantiate (imageHolder);
			tempIm.transform.SetParent(transform);//parent = transform;

			tempIm.GetComponent<RectTransform>().anchoredPosition = new Vector2(panelRect.rect.xMin + padding + (imHolderRect.rect.width * i + (padding *i)) + imHolderRect.rect.width / 2,panelRect.rect.center.y);
			tempIm.GetComponent<Image>().sprite = SpritesForCarousel[i];
		}
		panelRect.anchoredPosition = new Vector2 (parentRect.rect.xMin + panelRect.rect.width / 2, panelRect.rect.y + panelRect.rect.height/2);

	}
	
	// Update is called once per frame
	void Update ()
	{

	}
}
