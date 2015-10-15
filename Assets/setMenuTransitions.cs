using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class setMenuTransitions : MonoBehaviour
{
	Transform bg;
	slideBG slideRef;
	// Use this for initialization
	void Start ()
	{
		bg = transform.parent.GetComponent<PopulateMenu> ().BGReference;
		slideRef = bg.GetComponent<slideBG> ();
		transform.GetComponent<Button> ().onClick.AddListener (() => {slideRef.triggerChangeMenu(transform.GetComponentInChildren<Text>().text);});//triggerChangeMenu (transform.GetComponentInChildren<Text>().);});
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}
}
