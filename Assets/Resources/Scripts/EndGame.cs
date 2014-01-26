using UnityEngine;
using System.Collections;

public class EndGame : MonoBehaviour
{

    public GUIText endGameText;
    public string nextLevelName;

	bool won;

    string gameOverMessage, levelCompleteMessage;
    GameObject player, musicController, endMusicController;

    PlayerController playerController;
    EndMusic endMusic;
    PlayerHealth playerHealth;


    void Start()
    {
        player = GameObject.FindGameObjectWithTag(Tags.player);
        musicController = GameObject.FindGameObjectWithTag(Tags.musicController);
        endMusicController = GameObject.FindGameObjectWithTag(Tags.endMusicController);
        playerHealth = GameObject.FindGameObjectWithTag(Tags.playerHealth).GetComponent<PlayerHealth>();
		won = false;
        playerController = player.GetComponent<PlayerController>();
        endMusic = endMusicController.GetComponent<EndMusic>();
        gameOverMessage = "GAME\n OVER";
        levelCompleteMessage = "LEVEL\n COMPLETE";
        endGameText.enabled = false;

		EndGameOnTriggerEnter.endName += LoadNextLevel;
    }

    void Update()
    {
        if (playerHealth.Health <= 0)
        {
            EndGameInDefeat();
        }
    }

    public void EndGameInDefeat()
    {
        playerController.controlPlayer = false;
        player.renderer.enabled = false;
        musicController.audio.Stop();
        endMusicController.audio.clip = endMusic.defeatMusic;
        endMusicController.audio.Play();
        endGameText.text = gameOverMessage;
        endGameText.enabled = true;
    }

    public void EndGameInVictory()
    {
        playerController.controlPlayer = false;
        player.renderer.enabled = false;
        musicController.audio.Stop();
        endMusicController.audio.clip = endMusic.victoryMusic;
        endMusicController.audio.Play();
        endGameText.text = levelCompleteMessage;
        endGameText.enabled = true;
    }

    public void LoadNextLevel(bool x)
    {
		if(x)
		{
			won = true;
			//Application.LoadLevel(nextLevelName);
		}
        
    }

	void OnGUI()
	{
		if(won)
		{
			if(GUI.Button(new Rect(0f, Screen.height * 0.9f,Screen.width *0.25f,Screen.height * 0.1f),"Menu"))
			{
				Application.LoadLevel(nextLevelName);

			}
		}
	}
}