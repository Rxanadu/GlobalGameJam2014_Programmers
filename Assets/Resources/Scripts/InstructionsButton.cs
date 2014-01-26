using UnityEngine;
using System.Collections;

public class InstructionsButon : MonoBehaviour {

	public string nextScene;
	public string previousScene;
	public Texture pressedTexture;
	public Texture releasedTexture;

	public Texture2D image;

	private Texture _texture; // use for resume button
	GUIContent content = new GUIContent();

	//private string text = "Start";

	void Awake()
	{
		content.image = (Texture2D)image;
	}

	// Use this for initialization
	void Start () 
	{
		renderer.material.mainTexture = releasedTexture;
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetMouseButtonDown(0))
		{
			//Debug.Log("Pressed left click.");
			//renderer.material.mainTexture = texture;
		}
	}

	void OnGUI()
	{  
		int buttonWidth = 100;
		int buttonHeight = 60;
		int halfButtonWidth = buttonWidth/2;
		int halfScreenWidth = Screen.width/2;

		//GUI.skin.button.normal.background = (Texture2D)image;
		if(GUI.Button(new Rect(halfScreenWidth-halfButtonWidth, Screen.height/2+buttonHeight, buttonWidth, buttonHeight), "PLAY"))
		{
			Application.LoadLevel(nextScene);
		}
	}
	
	
	void OnMouseDown() {
		if (gameObject.name.Contains("Pause"))
		{
			releasedTexture =  Resources.Load("ResumeKey") as Texture;
			pressedTexture = Resources.Load("ResumeKeyPushed") as Texture;	
			renderer.material.mainTexture = pressedTexture;
		}
		else if (gameObject.name.Contains("Resume"))
		{
			releasedTexture =  Resources.Load("PauseKey") as Texture;
			pressedTexture = Resources.Load("PauseKeyPushed") as Texture;
			renderer.material.mainTexture = pressedTexture;
		}
		else if (gameObject.name.Contains("Button"))
		{
			renderer.material.mainTexture = pressedTexture;
		}
		//renderer.material.mainTexture = texture;
		//Application.LoadLevel("SomeLevel");
	}
	
	void OnMouseUp() 
	{
		Debug.Log("Mouse Up");
		renderer.material.mainTexture =  releasedTexture;
		if (this.gameObject.name.Contains ("Quit"))
		{
			Application.Quit();	
		}
		else if (this.gameObject.name.Contains ("Pause"))
		{
			this.gameObject.name = this.gameObject.name.Replace("Pause", "Resume");
			OnGamePause();
		}
		else if (this.gameObject.name.Contains ("Resume"))
		{
			this.gameObject.name = this.gameObject.name.Replace("Resume", "Pause");
			OnGameResume();
		}
		else if (this.gameObject.name.Contains ("Start"))
		{
			if(!nextScene.Equals(string.Empty))
				Application.LoadLevel(nextScene);
			else
				SceneNameIsNull();	
		}
		else if (this.gameObject.name.Contains ("Back"))
		{
			if(!previousScene.Equals(string.Empty))
				Application.LoadLevel(previousScene);
			else
				SceneNameIsNull();			
		}
	}
	
	void OnGamePause()
	{
		Debug.Log("Game Paused");
		
		Time.timeScale = 0;
		
		//		Object[] objects = FindObjectsOfType (typeof(GameObject));
		//		foreach (GameObject go in objects) 
		//		{
		//			go.SendMessage ("OnPauseGame", SendMessageOptions.DontRequireReceiver);
		//		}
	}
	
	void OnGameResume()
	{
		Debug.Log ("Game Resumed");
		//	releasedTexture =  Resources.Load("PauseKey") as Texture;
		//	pressedTexture = Resources.Load("PauseKeyPushed") as Texture;
		Time.timeScale = 1;
	}
	
	void SceneNameIsNull()
	{
		Debug.Log ("Scene name is null.");	
	}
}
