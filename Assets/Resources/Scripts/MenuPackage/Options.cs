using UnityEngine;
using System.Collections;

public class Options : MonoBehaviour
{

    public float minSliderValue = 1, maxSliderValue = 10;
    public MenuController menuController;
    public int optionsWidth, optionsHeight;

    Rect optionsArea;
    float resolutionPointer;
    float qualityPointer;
    bool fullscreenOn;
    bool audioOn;
    int optionX, optionY;
    float initVolume;

    void Start()
    {
        fullscreenOn = false;
        audioOn = true;
        initVolume = AudioListener.volume;
        resolutionPointer = Screen.currentResolution.width;
        qualityPointer = QualitySettings.GetQualityLevel();
        UpdateOptionsPosition();
    }

    void Update()
    {
        UpdateOptionsPosition();
    }

    void OnGUI()
    {
        GUILayout.BeginArea(optionsArea);
        //resolution
        DisplayResolutionSettings();

        //fullscreen toggle button
        DisplayFullscreenSettings();

        //quality settings
        DisplayQualitySettings();

        //audio settings
        DisplayAudioSettings();

        //apply and back buttons
        DisplayEndButtons();
        GUILayout.EndArea();
    }

    void UpdateOptionsPosition()
    {
        optionX = Screen.width / 2 - optionsWidth / 2;
        optionY = Screen.height / 2 - optionsHeight / 2;
        optionsArea = new Rect(optionX, optionY, optionsWidth, optionsHeight);
    }

    void DisplayResolutionSettings()
    {
        GUILayout.Label("Resolution");
        GUILayout.BeginHorizontal();
        resolutionPointer = GUILayout.HorizontalSlider(resolutionPointer, 0, Screen.resolutions.Length);
        
        if (resolutionPointer < Screen.resolutions.Length - 1)
        {
            GUILayout.Label(Screen.resolutions[(int)resolutionPointer].width +
                "x" + Screen.resolutions[(int)resolutionPointer].height);
        }
        GUILayout.EndHorizontal();
    }

    void DisplayFullscreenSettings()
    {
        GUILayout.BeginHorizontal();
        fullscreenOn = GUILayout.Toggle(fullscreenOn, "Fullscreen");
        GUILayout.EndHorizontal();
    }

    void DisplayQualitySettings()
    {
        GUILayout.Label("Quality");
        GUILayout.BeginHorizontal();
        qualityPointer = GUILayout.HorizontalSlider(qualityPointer, 0, QualitySettings.names.Length);
        
        if (qualityPointer < QualitySettings.names.Length - 1)
        {
            GUILayout.Label(QualitySettings.names[(int)qualityPointer]);
        }
        GUILayout.EndHorizontal();
    }

    void DisplayEndButtons()
    {
        GUILayout.BeginHorizontal();
        if (GUILayout.Button("Apply"))
            ApplyOptionsSettings();
        if (GUILayout.Button("Back"))
        {
            menuController.EnableMainMenu();
        }
        GUILayout.EndHorizontal();
    }

    void DisplayAudioSettings() {
        GUILayout.BeginHorizontal();
        audioOn = GUILayout.Toggle(audioOn, "Audio");
        SetAudioVolume();
        GUILayout.EndHorizontal();
    }

    void ApplyOptionsSettings()
    {
        Screen.SetResolution(Screen.resolutions[(int)resolutionPointer].width,
                Screen.resolutions[(int)resolutionPointer].height, fullscreenOn);
        QualitySettings.SetQualityLevel((int)qualityPointer, true);
        AudioListener.pause = audioOn;

    }

    void SetAudioVolume() {
        if (audioOn)
            AudioListener.volume = initVolume;
        else
            AudioListener.volume = 0;
    }
}