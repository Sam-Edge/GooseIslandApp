
using UnityEngine;
using System.Collections;

public class socialButton : MonoBehaviour {
	

	public Texture2D drawTexture = null;
	public Texture2D textureForPost;
	
	
	void Awake() {
		
		IOSSocialManager.OnFacebookPostResult += HandleOnFacebookPostResult;
		IOSSocialManager.OnTwitterPostResult += HandleOnTwitterPostResult;
		IOSSocialManager.OnInstagramPostResult += HandleOnInstagramPostResult;
		
		//actions use example:
		IOSSocialManager.OnMailResult += OnMailResult;

	}

		
		void twitterPost(){
			IOSSocialManager.instance.TwitterPost("Twitter posting test");
		}
		
		void twitterScreenShot() {
			StartCoroutine(PostTwitterScreenshot());
		}
		
		
		void facebookPost(){
		 IOSSocialManager.instance.FacebookPost("Facebook posting test");
		}
		
		void facebookScreenShot(){
			 StartCoroutine(PostFBScreenshot());
		}
		
		
		void faceBookPicture(){
			IOSSocialManager.instance.FacebookPost("Hello world", "https://www.edgedna.com", textureForPost);
		}
		
		
		void nativeMedia(){
			IOSSocialManager.instance.ShareMedia("Some text to share");
		}
		
		void nativeScreenShot(){
			StartCoroutine(PostScreenshot());
		}
		
		
		void sendEmail(){
			IOSSocialManager.instance.SendMail("Mail Subject", "Mail Body  <strong> text html </strong> ", "mail1@gmail.com, mail2@gmail.com", textureForPost);
		}
		
	 	void instagramPic(){
			IOSCamera.OnImagePicked += OnPostImageInstagram;
			IOSCamera.Instance.PickImage(ISN_ImageSource.Camera);
		}
		
		void instaScreenShot(){
			StartCoroutine(PostScreenshotInstagram());
		}
		
		void saveScreenShot(){
		IOSCamera.Instance.SaveScreenshotToCameraRoll();
		}

	
	
	private void OnPostImageInstagram (IOSImagePickResult result) {
		if(result.IsSucceeded) {
			
			Destroy(drawTexture);
			
			drawTexture = result.Image;
		} else {
			IOSMessage.Create("ERROR", "Image Load Failed");
		}
		IOSSocialManager.instance.InstagramPost(drawTexture ,"Some text to share");
		IOSCamera.OnImagePicked -= OnPostImageInstagram;
	}
	
	private IEnumerator PostScreenshotInstagram() {
		
		yield return new WaitForEndOfFrame();
		// Create a texture the size of the screen, RGB24 format
		int width = Screen.width;
		int height = Screen.height;
		Texture2D tex = new Texture2D( width, height, TextureFormat.RGB24, false );
		// Read screen contents into the texture
		tex.ReadPixels( new Rect(0, 0, width, height), 0, 0 );
		tex.Apply();
		
		IOSSocialManager.instance.InstagramPost(tex, "Some text to share");
		
		Destroy(tex);
		
	}
	
	
	private IEnumerator PostScreenshot() {
		
		yield return new WaitForEndOfFrame();
		// Create a texture the size of the screen, RGB24 format
		int width = Screen.width;
		int height = Screen.height;
		Texture2D tex = new Texture2D( width, height, TextureFormat.RGB24, false );
		// Read screen contents into the texture
		tex.ReadPixels( new Rect(0, 0, width, height), 0, 0 );
		tex.Apply();
		
		IOSSocialManager.instance.ShareMedia("Some text to share", tex);
		
		Destroy(tex);
		
	}
	
	private IEnumerator PostTwitterScreenshot() {
		
		yield return new WaitForEndOfFrame();
		// Create a texture the size of the screen, RGB24 format
		int width = Screen.width;
		int height = Screen.height;
		Texture2D tex = new Texture2D( width, height, TextureFormat.RGB24, false );
		// Read screen contents into the texture
		tex.ReadPixels( new Rect(0, 0, width, height), 0, 0 );
		tex.Apply();
		
		IOSSocialManager.instance.TwitterPost("My app Screenshot", null,  tex);
		
		Destroy(tex);
		
	}
	
	private IEnumerator PostFBScreenshot() {
		
		
		yield return new WaitForEndOfFrame();
		// Create a texture the size of the screen, RGB24 format
		int width = Screen.width;
		int height = Screen.height;
		Texture2D tex = new Texture2D( width, height, TextureFormat.RGB24, false );
		// Read screen contents into the texture
		tex.ReadPixels( new Rect(0, 0, width, height), 0, 0 );
		tex.Apply();
		
		IOSSocialManager.instance.FacebookPost("My app Screenshot", null, tex);
		
		Destroy(tex);
		
	}
	
	
	
	void HandleOnInstagramPostResult (ISN_Result res){
		if (res.IsSucceeded) {
			IOSNativePopUpManager.showMessage ("Posting example", "Post Success!");
		} else {
			IOSNativePopUpManager.showMessage ("Posting example", "Post Failed :(");
		}
	}
	
	
	void HandleOnTwitterPostResult (ISN_Result res){
		if(res.IsSucceeded) {
			IOSNativePopUpManager.showMessage("Posting example", "Post Success!");
		} else {
			IOSNativePopUpManager.showMessage("Posting example", "Post Failed :(");
		}
	}
	
	void HandleOnFacebookPostResult (ISN_Result res) {
		if(res.IsSucceeded) {
			IOSNativePopUpManager.showMessage("Posting example", "Post Success!");
		} else {
			IOSNativePopUpManager.showMessage("Posting example", "Post Failed :(");
		}
	}
	
	
	private void OnMailResult (ISN_Result result) {
		if(result.IsSucceeded) {
			
			IOSNativePopUpManager.showMessage("Posting example", "Mail Sent");
		} else {
			IOSNativePopUpManager.showMessage("Posting example", "Mail Failed :(");
		}
	}
	
	
}

