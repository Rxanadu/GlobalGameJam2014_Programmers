using UnityEngine;
using System.Collections;

/// <summary>
/// @Usage: place on all GUI elements related to 
///     the designated game menus for your game
/// </summary>
public class OptionMenus : MonoBehaviour
{

    public enum GameMenus
    {
        PlayGame,
        Pause,
        Retry,
        Resume,
        QuitToMainMenu,
        QuitGame
    }

    public GameMenus menu = GameMenus.PlayGame;

    public string levelName;
    public bool isGUIText;

    Texture overTexture, exitTexture;
    Color offColor, onColor;
    GUIButtonSkin buttonSkin;

    void Start() {
        InitializeValues();
    }

    void InitializeValues() {
        buttonSkin = GameObject.FindGameObjectWithTag(Tags.buttonSounds).
            GetComponent<GUIButtonSkin>();

        offColor = buttonSkin.mouseOffColor;
        onColor = buttonSkin.mouseOverColor;
        overTexture = buttonSkin.mouseOverTexture;
        exitTexture = buttonSkin.mouseExitTexture;
    }

    void OnMouseEnter() {
        if (isGUIText)
            GetComponent<GUIText>().color = onColor;
        else 
            GetComponent<GUITexture>().texture = overTexture;
        buttonSkin.PlayMouseOverSound();
    }

    void OnMouseExit() {
        if (isGUIText)
            GetComponent<GUIText>().color = offColor;
        else
            GetComponent<GUITexture>().texture = exitTexture;
    }

    void OnMouseDown()
    {
        buttonSkin.PlayMouseClickSound();
        PerformActionForMenu();
    }

    void PerformActionForMenu()
    {
        switch (menu)
        {
            case GameMenus.Resume:
                //resume game from pause state
                break;
            case GameMenus.PlayGame:
                Application.LoadLevel(levelName);
                break;
            case GameMenus.Pause:
                if (GameObject.FindGameObjectWithTag(Tags.gameController)) { 
                //pause game
                }
                break;
            case GameMenus.Retry:
                Application.LoadLevel(Application.loadedLevel);
                break;
            case GameMenus.QuitToMainMenu:
                if(levelName != null)
                    Application.LoadLevel(levelName);
                break;
            case GameMenus.QuitGame:
                Application.Quit();
                break;
        }
    }
}