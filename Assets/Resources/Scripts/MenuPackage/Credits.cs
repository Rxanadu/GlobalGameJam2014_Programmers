using UnityEngine;
using System.Collections;

/// <summary>
/// modification of a Credits script made by "robin.theilade" on the Unity Answers thread found here:
///     http://answers.unity3d.com/questions/315124/in-game-credits.html
///     Please give this person support; with out this person, this modification would not exist
/// Modifications:
///     placement of original code
///     making viewArea into a private Rect object to make use of Screen.width and Screen.height variables
///     adding public TextAsset variable to use for placing custom text documents within credits
///     comments explaining what each function performs 
/// </summary>
public class Credits : MonoBehaviour
{

    float offset;                           //y-axis offset used to scroll text upward
    Rect viewArea;                          //area in which credits will appear
    Rect position;

    public float speed = 9.0f;              //speed at which credits will scroll
    public GUIStyle creditsStyle;           //style in which credits will appear in-game
    public TextAsset creditsText;           //text document used for credits
    public bool isScrolling = false;

    public MenuController menuController;

    void Start()
    {
        InitializeValuesForScript();
    }

    void Update()
    {
        //keeps view area as large as the screen in all aspect ratios
        viewArea = new Rect(0, 0, Screen.width, Screen.height);

        if (isScrolling) {
            ScrollCredits();
        }
    }

    void OnGUI()
    {
        DisplayCredits();
    }

    //initialize all global private variables used in this script
    void InitializeValuesForScript() {
        viewArea = new Rect(0, 0, Screen.width, Screen.height);
        offset = this.viewArea.height;
    }

    //creates view area for placing credits inside
    void DisplayCredits()
    {
        GUI.BeginGroup(this.viewArea);
        if (isScrolling)
        {
            position = new Rect(0, offset, this.viewArea.width, this.viewArea.height);
        }
        else {
            position = new Rect(0,0, this.viewArea.width, this.viewArea.height);
        }

        string text = SetExampleText();

        if (creditsText != null)
            GUI.Label(position, creditsText.text, this.creditsStyle);            
        else
            GUI.Label(position, text, this.creditsStyle);

        if (GUILayout.Button("Back")) {
            menuController.EnableMainMenu();
        }
        GUI.EndGroup();
    }

    void ScrollCredits() {
        //scrolls text upward based time step
        offset -= Time.deltaTime * this.speed;
    }

    //sets up example text to test script with if no 
    //  credit text documents are available within the project
    string SetExampleText()
    {
        string text;

        text = @"Lorem ipsum dolor sit amet, consectetur adipiscing elit.
Quisque a mauris sit amet neque posuere molestie at laoreet lorem.
Suspendisse accumsan pretium ante, sit amet tincidunt tortor tempor ac.
 
 
 
Sed condimentum mi id nisi egestas non vulputate urna porttitor.
Mauris sed mauris vitae velit imperdiet vulputate ut nec velit.
Maecenas convallis posuere velit, quis interdum justo mattis vel.
 
 
 
Aliquam hendrerit ullamcorper dui, a laoreet dolor ornare sit amet.
Praesent sed odio purus, a convallis tellus.
Nulla porttitor arcu vel ipsum luctus euismod.
 
 
 
Duis tincidunt vehicula nisl, nec venenatis velit convallis non.
Sed semper metus egestas libero venenatis imperdiet.
Pellentesque venenatis orci nisi, vel fringilla dolor.
 
 
 
Nam at lacus massa, commodo pellentesque velit.
In accumsan velit sed nisi aliquam tristique.
Ut eu quam tellus, eu egestas diam.
 
 
 
Maecenas vel dui vitae orci accumsan molestie.
Donec pulvinar metus nec turpis rutrum quis gravida ante dignissim.
Ut quis justo quis nisl eleifend ornare non at ipsum.";

        return text;
    }
}