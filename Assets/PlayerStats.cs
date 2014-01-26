using UnityEngine;
using System.Collections;
using System;

public class PlayerStats : MonoBehaviour 
{
	public int health = 15;
	public Texture healthIcon;
	public Vector3 spawnPoint;
	public bool lastSpawn;
	public GameObject lastWaterCooler;
	// Use this for initialization
	void Start () 
	{
		spawnPoint = transform.position;
		lastSpawn = true;
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(health<=0)
		{
			if(lastSpawn)
			{
			//	respawn(spawnPoint);
			}
			else
			{
				//game over
			}
		}
	}

	void OnCollisionEnter(Collision other)
	{
		if(other.gameObject.name =="Snitch")
		{
			health-=1;
		}
		else if(other.gameObject.name =="Prankster")
		{
			health-=2;
		}
		else if(other.gameObject.name =="Janitor")
		{
			health-=4;
		}
		else if(other.gameObject.name =="Jockey")
		{
			health-=3;
		}
		else if(other.gameObject.name == "Water Cooler")
		{
			health = 15;
			lastSpawn = true;
		}
	}

	void respawn()
	{
		transform.position = lastWaterCooler.transform.position;
		//lastWaterCooler.SendMessage("Used");
		lastSpawn = false;
	}

	void OnGUI()
	{
		switch(health)
		{
		case 0:// player has only one round left
			break;
		case 1:
			GUI.Box(new Rect(Screen.width * .25f,Screen.height * 0.125f, Screen.width * .04f, Screen.height * .04f),healthIcon);
			break;
		case 2:
			GUI.Box(new Rect(Screen.width * .25f,Screen.height * 0.125f, Screen.width * .04f, Screen.height * .04f),healthIcon);
			GUI.Box(new Rect(Screen.width * .29f,Screen.height * 0.125f, Screen.width * .04f, Screen.height * .04f),healthIcon);
			break;
		case 3:
			GUI.Box(new Rect(Screen.width * .25f,Screen.height * 0.125f, Screen.width * .04f, Screen.height * .04f),healthIcon);
			GUI.Box(new Rect(Screen.width * .29f,Screen.height * 0.125f, Screen.width * .04f, Screen.height * .04f),healthIcon);
			GUI.Box(new Rect(Screen.width * .33f,Screen.height * 0.125f, Screen.width * .04f, Screen.height * .04f),healthIcon);
			break;
		case 4:
			GUI.Box(new Rect(Screen.width * .25f,Screen.height * 0.125f, Screen.width * .04f, Screen.height * .04f),healthIcon);
			GUI.Box(new Rect(Screen.width * .29f,Screen.height * 0.125f, Screen.width * .04f, Screen.height * .04f),healthIcon);
			GUI.Box(new Rect(Screen.width * .33f,Screen.height * 0.125f, Screen.width * .04f, Screen.height * .04f),healthIcon);
			GUI.Box(new Rect(Screen.width * .37f,Screen.height * 0.125f, Screen.width * .04f, Screen.height * .04f),healthIcon);
			break;
		case 5:
			GUI.Box(new Rect(Screen.width * .25f,Screen.height * 0.125f, Screen.width * .04f, Screen.height * .04f),healthIcon);
			GUI.Box(new Rect(Screen.width * .29f,Screen.height * 0.125f, Screen.width * .04f, Screen.height * .04f),healthIcon);
			GUI.Box(new Rect(Screen.width * .33f,Screen.height * 0.125f, Screen.width * .04f, Screen.height * .04f),healthIcon);
			GUI.Box(new Rect(Screen.width * .37f,Screen.height * 0.125f, Screen.width * .04f, Screen.height * .04f),healthIcon);
			GUI.Box(new Rect(Screen.width * .41f,Screen.height * 0.125f, Screen.width * .04f, Screen.height * .04f),healthIcon);
			break;
		default:// five gui boxes and a plus indicate more bullets
			GUI.Box(new Rect(Screen.width * .25f,Screen.height * 0.125f, Screen.width * .04f, Screen.height * .04f),healthIcon);
			GUI.Box(new Rect(Screen.width * .29f,Screen.height * 0.125f, Screen.width * .04f, Screen.height * .04f),healthIcon);
			GUI.Box(new Rect(Screen.width * .33f,Screen.height * 0.125f, Screen.width * .04f, Screen.height * .04f),healthIcon);
			GUI.Box(new Rect(Screen.width * .37f,Screen.height * 0.125f, Screen.width * .04f, Screen.height * .04f),healthIcon);
			GUI.Box(new Rect(Screen.width * .41f,Screen.height * 0.125f, Screen.width * .04f, Screen.height * .04f),healthIcon);
			GUI.Box(new Rect(Screen.width * .45f,Screen.height * 0.125f, Screen.width * .04f, Screen.height * .04f),healthIcon);
			break;
		}
	}
}
