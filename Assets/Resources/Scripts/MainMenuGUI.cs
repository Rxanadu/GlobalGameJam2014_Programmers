using UnityEngine;
using System.Collections;

public enum MenuStates2{Main,Credits,HowTo};

public class MainMenuGUI : MonoBehaviour 
{
	//this is the script for gui in the main menu
	public MenuStates2 currentState;
	// Use this for initialization
	void Start () 
	{
		currentState = MenuStates2.Main;
	}
	
	// Update is called once per frame
	void Update () 
	{
		switch(currentState)
		{
		case MenuStates2.Main:
			break;
		case MenuStates2.HowTo:
			break;
		case MenuStates2.Credits:
			break;
		}
	}

	void OnGUI()
	{
		switch(currentState)
		{
		case MenuStates2.Main:
			/*
			if (GUI.Button(Rect(Screen.width * 0.25f, Screen.height * 0.25, Screen.width * 0.5f, Screen.height * 0.15f), "Play") == true)
			{
				
			}
			if (GUI.Button(Rect(Screen.width * 0.25f, Screen.height * 0.4, Screen.width * 0.5f, Screen.height * 0.15f), "How to Play") == true)			
			{
				
			}
			if (GUI.Button(Rect(Screen.width * 0.25f, Screen.height * 0.55, Screen.width * 0.5f, Screen.height * 0.15f), "Credits") == true)			
			{
				
			}*/
			break;
		}


	}
}
