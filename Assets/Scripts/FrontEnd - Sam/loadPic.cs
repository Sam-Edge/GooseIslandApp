using UnityEngine;
using System.Collections;

public class loadPic : MonoBehaviour {
	public string url1 = "https://scontent.cdninstagram.com/hphotos-xaf1/t51.2885-15/e15/11348095_115973948747270_407638194_n.jpg";
	public string url2 = "https://scontent.cdninstagram.com/hphotos-xaf1/t51.2885-15/s640x640/sh0.08/e35/11324883_1639044979671152_1260197333_n.jpg";
	public string url3 = "https://scontent.cdninstagram.com/hphotos-xaf1/t51.2885-15/s640x640/sh0.08/e35/11355988_780704755383958_1675068876_n.jpg";
	public string url4 = "https://scontent.cdninstagram.com/hphotos-xaf1/t51.2885-15/e15/11265202_1462322670738241_865461716_n.jpg";
	public string url5 = "https://scontent.cdninstagram.com/hphotos-xpa1/t51.2885-15/s640x640/sh0.08/e35/10731916_1458708237765079_1721717783_n.jpg";
	public string url6 = "https://scontent.cdninstagram.com/hphotos-xaf1/t51.2885-15/s640x640/sh0.08/e35/11325156_385253575017955_354436725_n.jpg";
	public string url7 = "https://scontent.cdninstagram.com/hphotos-xaf1/t51.2885-15/s640x640/sh0.08/e35/11375262_405626622960701_1433458993_n.jpg";
	public string url8 = "https://scontent.cdninstagram.com/hphotos-xpa1/t51.2885-15/e15/10666018_675238089244513_668629962_n.jpg";
	public string url9 = "https://scontent.cdninstagram.com/hphotos-xaf1/t51.2885-15/s640x640/sh0.08/e35/11378145_393382017519535_424198380_n.jpg";
	public string url10 = "https://scontent.cdninstagram.com/hphotos-xaf1/t51.2885-15/s640x640/sh0.08/e35/11375346_120390024971018_1099197659_n.jpg";
	private int count = 1;

	void Start()
	{

		GetComponent<Renderer>().material.mainTexture = new Texture2D(4, 4, TextureFormat.DXT1, false);
		StartCoroutine(UpdateCam());
	}
	
	IEnumerator UpdateCam()
	{
		while (true)
		{

			string url = url1;
			if(count == 2)
				{url = url2;}
			else if(count == 3)
			{url = url3;}
			else if(count == 4)
			{url = url4;}
			else if(count == 5)
			{url = url5;}
			else if(count == 6)
			{url = url6;}
			else if(count == 7)
			{url = url7;}
			else if(count == 8)
			{url = url8;}
			else if(count == 9)
			{url = url9;}
			else if(count == 10)
			{url = url10;}
			else{ Debug.Log("Error, cant get count"); }
			WWW www = new WWW(url);
			yield return www;
			www.LoadImageIntoTexture((Texture2D)GetComponent<Renderer>().material.mainTexture);

		}
	}

	void OnMouseDown(){

		if (GameObject.Find ("InstaPlane").GetComponent<Renderer>().enabled == true) {
			if (count < 10) {
				count++;
				Debug.Log (count);
			} else if(count == 10) {
				Debug.Log (count);
				count = 1;
			}
			else Debug.Log ("Error");
		}
	}

}

/*
 * 
 * Debug.Log("reloading picture");
			WWW www = new WWW(url1);
			yield return www;
			www.LoadImageIntoTexture((Texture2D)renderer.material.mainTexture);
			*/