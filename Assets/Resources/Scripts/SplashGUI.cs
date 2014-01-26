using UnityEngine;
using System.Collections;

public class SplashGUI : MonoBehaviour {

	public GUISkin customSkin = null;

	public void OnGUI()
	{
		if(customSkin != null)
			GUI.skin = customSkin;

		int buttonWidth = 100;
		int buttonHeight = 60;
		int halfButtonWidth = buttonWidth/2;
		int halfScreenWidth = Screen.width/2;

		if(GUI.Button(new Rect(halfScreenWidth-halfButtonWidth, Screen.height/2+buttonHeight, buttonWidth, buttonHeight), "PLAY"))
		{
			Application.LoadLevel("Instructions");
		}
	}
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
	