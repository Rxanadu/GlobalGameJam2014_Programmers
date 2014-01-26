using UnityEngine;
using System.Collections;

public class LoadGame : MonoBehaviour {

    public int loadGameWidth, loadGameHeight;
    public int spaceOffset;
    public Vector2 saveFilesArea;  //within loadGameArea
    public Vector2 saveInfoArea;
    public int[] saveSlots;
    public MenuController menuController;

    Rect loadGameArea;   //surrounds all of load area
    int loadGameX, loadGameY;

    void Start() {
        UpdateLoadGameArea();
    }

    void Update() {
        UpdateLoadGameArea();
    }

    void OnGUI() {
        GUILayout.BeginArea(loadGameArea);
        GUILayout.BeginHorizontal();
        //save slots area
        saveFilesArea = GUILayout.BeginScrollView(saveFilesArea);
        for (int i = 0; i < saveSlots.Length;i++ )
        {
            GUILayout.Button("Save " + i);
        }
        GUILayout.EndScrollView();

        //save information area
        saveInfoArea = GUILayout.BeginScrollView(saveInfoArea);
        //TODO: display save infomation here
        GUILayout.EndScrollView();
        GUILayout.EndHorizontal();
        GUILayout.Space(spaceOffset);
        GUILayout.BeginHorizontal();
        if (GUILayout.Button("Load Game"))
        {
            //load selected save file
        }
        if (GUILayout.Button("Back"))
        {
            menuController.EnableMainMenu();
        }
        GUILayout.EndHorizontal();
        GUILayout.EndArea();
    }

    void UpdateLoadGameArea() {
        loadGameX = Screen.width / 2 - loadGameWidth / 2;
        loadGameY = Screen.height / 2 - loadGameHeight / 2;
        loadGameArea = new Rect(loadGameX,loadGameY,loadGameWidth,loadGameHeight);
    }
}
