using UnityEngine;
using System.Collections;

public class MenuController : MonoBehaviour
{

    public Credits credits;
    public MainMenu mainMenu;
    public Options options;
    public LoadGame loadGame;
    public HowToPlay howToPlay;

    void Awake()
    {
        if (mainMenu != null)
            EnableMainMenu();
    }

    public void EnableMainMenu()
    {
        if (mainMenu.enabled == false)
            mainMenu.enabled = true;
        credits.enabled = false;
        options.enabled = false;
        loadGame.enabled = false;
        howToPlay.enabled = false;
    }

    public void EnableCredits()
    {
        mainMenu.enabled = false;
        if (credits.enabled == false)
            credits.enabled = true;
        options.enabled = false;
        loadGame.enabled = false;
        howToPlay.enabled = false;
    }

    public void EnableOptions()
    {
        mainMenu.enabled = false;
        credits.enabled = false;
        if (options.enabled == false)
            options.enabled = true;
        loadGame.enabled = false;
        howToPlay.enabled = false;
    }

    public void EnableLoadGame()
    {
        mainMenu.enabled = false;
        credits.enabled = false;
        options.enabled = false;
        if (loadGame.enabled == false)
            loadGame.enabled = true;
        howToPlay.enabled = false;
    }

    public void EnableHowToPlay() {
        mainMenu.enabled = false;
        credits.enabled = false;
        options.enabled = false;
        loadGame.enabled = false;
        if (howToPlay.enabled == false)
            howToPlay.enabled = true;
    }

    public void EnablePauseMenu()
    {

    }
}