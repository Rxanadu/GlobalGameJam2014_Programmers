using UnityEngine;
using System.Collections;

public class EndMusic : MonoBehaviour {

	public AudioClip victoryMusic, defeatMusic;

	void Start(){
		audio.clip = null;
		audio.loop=false;
	}
}
