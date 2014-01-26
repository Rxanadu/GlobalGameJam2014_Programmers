using UnityEngine;
using System.Collections;

public class HowToPlay : MonoBehaviour
{

    Rect howToPlayArea;
    int howToPlayX, howToPlayY;
    Vector2 howToPlayScrollView;

    public int howToPlayWidth, howToPlayHeight;
    public TextAsset howToPlayText;
    public MenuController menuController;

    void Start()
    {
        UpdateHowToPlayArea();
    }

    void Update()
    {
        UpdateHowToPlayArea();
    }

    void OnGUI()
    {
        GUILayout.BeginArea(howToPlayArea);
        //display how to play instructions
        DisplayHowToPlayInstructions();

        //display end buttons
        DisplayEndButtons();
        GUILayout.EndArea();
    }

    void UpdateHowToPlayArea()
    {
        howToPlayX = Screen.width / 2 - howToPlayWidth / 2;
        howToPlayY = Screen.height / 2 - howToPlayHeight / 2;
        howToPlayArea = new Rect(howToPlayX, howToPlayY, howToPlayWidth, howToPlayHeight);
    }

    void DisplayHowToPlayInstructions() {
        howToPlayScrollView = GUILayout.BeginScrollView(howToPlayScrollView);
        
        if (howToPlayText != null)
            GUILayout.Label(howToPlayText.text);
        GUILayout.EndScrollView();
    }

    void DisplayEndButtons()
    {
        GUILayout.BeginHorizontal();        
        if (GUILayout.Button("Back"))
        {
            menuController.EnableMainMenu();
        }
        GUILayout.EndHorizontal();
    }
}