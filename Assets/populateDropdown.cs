using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public class populateDropdown : MonoBehaviour
{
	int yearRange = 55;
	int yearStart = DateTime.Today.Year;
	RectTransform thisRect;
	Dropdown thisDrop;
	// Use this for initialization
	void Start ()
	{
		thisRect = transform.GetComponent<RectTransform> ();
		thisDrop = thisRect.GetComponent<Dropdown> ();

		if (transform.name == "Year") {

			for(int i = 0; i < yearRange; i++){
				thisDrop.options.Add(new Dropdown.OptionData((yearStart - i).ToString()));
			}

			//thisDrop.options.Add(new Dropdown.OptionData("2002"));
			//print(Dropdown.OptionData("2002"));
			//thisDrop.options.Clear();
			//Dropdown.OptionData("2002");
			//thisDrop.options.Add(Dropdown.OptionData("2002")); 
			//thisDrop.options[0] =Dropdown.OptionData("2002");// Dropdown.OptionData("2002");


			// test;

			//thisDrop.options.Add(Dropdown.OptionData("2002"));// test = Dropdown.OptionData("2002");
			//thisDrop.options.Add(Dropdown.OptionData("2002"));// as Dropdown.OptionData;// as optio
			//for(//thisDrop.options.Add ("2002");
			print ("Year");
		} else if (transform.name == "Month") {
			print ("Month");
		} else if (transform.name == "Day") {
			print ("Day");
		}


	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}
}
