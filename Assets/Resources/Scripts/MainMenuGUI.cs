using UnityEngine;
using System.Collections;

public enum MenuStates{Main,Credits,HowTo};

public class MainMenuGUI : MonoBehaviour 
{
	//this is the script for gui in the main menu
	public MenuStates currentState;
	// Use this for initialization
	void Start () 
	{
		currentState = MenuStates.Main;
	}
	
	// Update is called once per frame
	void Update () 
	{
		switch(currentState)
		{
		case MenuStates.Main:
			break;
		case MenuStates.HowTo:
			break;
		case MenuStates.Credits:
			break;
		}
	}

	void OnGUI()
	{
		switch(currentState)
		{
		case MenuStates.Main:
			if (GUI.Button(Rect(Screen.width * 0.25f, Screen.height * 0.25, Screen.width * 0.5f, Screen.height * 0.15f), "Play") == true)
			{
				
			}
			if (GUI.Button(Rect(Screen.width * 0.25f, Screen.height * 0.4, Screen.width * 0.5f, Screen.height * 0.15f), "How to Play") == true)			
			{
				
			}
			if (GUI.Button(Rect(Screen.width * 0.25f, Screen.height * 0.55, Screen.width * 0.5f, Screen.height * 0.15f), "Credits") == true)			
			{
				
			}
			break;
		}


	}
}
