using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour
{

    public GUITexture titleTexture;    
    public GUISkin menuSkin;
    public MenuController menuController;    
    public int menuWidth, menuHeight;
    public bool leaderboardsAvailable;

    Rect menuArea;
    int menuX, menuY;

    void Start() {
        if (titleTexture != null)
            titleTexture.enabled = true; 
        UpdateMainMenuPosition();
    }

    void Update() {
        if (titleTexture != null)
            titleTexture.enabled = true; 
        UpdateMainMenuPosition();
    }

    void OnGUI()
    {
        GUI.skin = menuSkin;

        GUILayout.BeginArea(menuArea);
        GUILayout.BeginVertical();              
        //if (GUILayout.Button("New Game"))
        //{
        //    //load new game
        //}
        //if (GUILayout.Button("Load Game"))
        //{
        //    //load save menu
        //    menuController.EnableLoadGame();
        //}
        if (GUILayout.Button("Play Game"))
        {
            //load new game
        }
        if (GUILayout.Button("How To Play")) { 
            //display "How to play" information
            menuController.EnableHowToPlay();
        }
        //if (GUILayout.Button("Level Select")) { 
        //    //load level select menu        
        //}
        //if (GUILayout.Button("Options"))
        //{
        //    //load options menu
        //    menuController.EnableOptions();
        //}
        if (leaderboardsAvailable) {
            if (GUILayout.Button("Leaderboards")) { 
                //display leaderboards
            }
        }
        if (GUILayout.Button("Credits")) { 
            //show credits
            menuController.EnableCredits();
        }
        if (Application.platform == RuntimePlatform.WindowsPlayer ||
           Application.platform == RuntimePlatform.OSXPlayer)
        {
            if (GUILayout.Button("Quit to Desktop"))
            {
                Application.Quit();
            }
        }
        GUILayout.EndVertical();
        GUILayout.EndArea();
    }

    void UpdateMainMenuPosition()
    {
        menuX = 40;
        menuY = Screen.height / 2 - menuHeight / 2;
        menuArea = new Rect(menuX, menuY, menuWidth, menuHeight);
    }
}