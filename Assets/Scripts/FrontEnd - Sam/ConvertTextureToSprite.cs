using UnityEngine;
using System.Collections;

public class ConvertTextureToSprite : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public Sprite InstagramToSprite(Texture2D instagramTexture){
		return Sprite.Create (instagramTexture, new Rect (0, 0, instagramTexture.width, instagramTexture.height), new Vector2 (0.5f, 0.5f));

	}

}
