using UnityEngine;
using System.Collections;
using System;

public class EndGameOnTriggerEnter : MonoBehaviour {

	public float endGameWait = 1f;
	public EndGame endGame;
	public static event Action<bool> endName;

	void OnTriggerEnter(Collider other){
		if(other.tag==Tags.player){
			//end Game
			endGame.EndGameInVictory();
			endName(true);
            Invoke("endGame.LoadNextLevel", endGameWait);
		}
	}
}
