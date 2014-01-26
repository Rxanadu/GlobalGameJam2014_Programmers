using UnityEngine;
using System.Collections;

public class WaterCooler : MonoBehaviour
{
	public int health;
	bool activated,used;
	// Update is called once per frame
	
	void Update ()
	{
		if(health<= 0 || used)
		{
			Destroy(this.gameObject);
		}

	}

	void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.tag =="Player")
		{
			activated = true;
		}
		if(other.gameObject.tag=="Enemy")
		{
			health--;
		}
	}

	void Used()
	{
		used = true;
	}
}
