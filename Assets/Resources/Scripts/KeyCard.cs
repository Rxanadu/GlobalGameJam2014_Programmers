using UnityEngine;
using System.Collections;
using System;

public class KeyCheck : MonoBehaviour
{
	public static event Action<bool> clearanceUp;
	// Update is called once per frame

	void OnDestroy()
	{
		clearanceUp(true);
	}

}
