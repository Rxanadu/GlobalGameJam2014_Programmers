using UnityEngine;
using System.Collections;
using System;

public class ElevatorTrigger : MonoBehaviour 
{
	public GameObject platform;

	void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.tag =="Player")
		{
			platform.SendMessage("move");
		}

	}
	void OnTriggerExit(Collider other)
	{
		if(other.gameObject.tag =="Player")
		{
			platform.SendMessage("stop");
		}
	}
}
