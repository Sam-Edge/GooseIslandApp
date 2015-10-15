using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SetICarouselSprite : MonoBehaviour {
	public Texture2D test1;
	public Sprite test2;
	static Transform thisTrans;
	// Use this for initialization
	void Start () {
		thisTrans = transform;
	}

	static void setImage(Texture2D texIn){
		thisTrans.GetComponent<Image> ().sprite = Sprite.Create (texIn, new Rect (0, 0, texIn.width, texIn.height), new Vector2 (0.5f, 0.5f));
	}

	static void setImage(Sprite spriteIn){
		thisTrans.GetComponent<Image> ().sprite = spriteIn;
	}

	// Update is called once per frame
	void Update () {
	
	}
	void openInstagram(){
		print ("Clicked to open instagram");
		//code to launch to instagram goes here
	}

}
