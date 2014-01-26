using UnityEngine;
using System.Collections;

public class EndGameOnTriggerEnter : MonoBehaviour {

	public float endGameWait = 1f;
	public EndGame endGame;

    

	void OnTriggerEnter(Collider other){
		if(other.tag==Tags.player){
			//end Game
			endGame.EndGameInVictory();
		}
	}
}
