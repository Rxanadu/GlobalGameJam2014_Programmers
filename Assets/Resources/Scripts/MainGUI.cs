using UnityEngine;
using System.Collections;

public enum MenuStates{Main,Credits,HowTo};

public class MainGUI : MonoBehaviour 
{

	//this is the script for gui in the main menu
	public MenuStates currentState;
	// Use this for initialization
	public GameObject background;

	public Texture wall,instructions,PlayButton,HowToButton,CreditsButton,BackButton,credits;
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
			//play button
			background.renderer.material.mainTexture = wall;
			
			if(GUI.Button(new Rect(Screen.width *0.25f,Screen.height * 0.25f, Screen.width * 0.5f,Screen.height*.15f),PlayButton))
			{
				//Application.LoadLevel("LevelOne");
			}
			//instructions
			if(GUI.Button(new Rect(Screen.width *0.25f,Screen.height * 0.4f, Screen.width * 0.5f,Screen.height*.15f),"How to Play"))
			{
				currentState = MenuStates.HowTo;
			}
			//credits
			if(GUI.Button(new Rect(Screen.width *0.25f,Screen.height * 0.55f, Screen.width * 0.5f,Screen.height*.15f),"Credits"))
			{
				currentState = MenuStates.Credits;
			}

			break;
		case MenuStates.Credits:
			//GUI.Box(new Rect(Screen.width *0.25f,Screen.height * 0.25f, Screen.width * 0.5f,Screen.height*.4f), "Credit To: Chris Harris, Joseph DuBois, Edgar Onukwgha, Rhys Maus, Jab Valiente, Laura Taylor, and Syedali Nabi");
			background.renderer.material.mainTexture = credits;
			if(GUI.Button(new Rect(0,Screen.height * 0.875f, Screen.width * 0.25f,Screen.height*.125f),"Back"))
			{
				currentState = MenuStates.Main;
			}
			break;
		case MenuStates.HowTo:
			//GUI.Box(new Rect(Screen.width *0.25f,Screen.height * 0.25f, Screen.width * 0.5f,Screen.height*.4f), instructions);
			background.renderer.material.mainTexture = instructions;
			if(GUI.Button(new Rect(0,Screen.height * 0.875f, Screen.width * 0.25f,Screen.height*.125f),"Back"))
			{
				currentState = MenuStates.Main;
			}
			break;
		default:
			break;
		}
		
		
	}
}
