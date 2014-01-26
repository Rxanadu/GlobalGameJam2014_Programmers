using UnityEngine;
using System.Collections;

public class PlayerHealth : MonoBehaviour 
{

    public GUIText healthText;
    public int maxHealth = 10;
	public Texture icon;
    int health;

    public int Health { 
        get { return health; }
        set { value = health; }
    }

    // Use this for initialization
    void Start()
    {
        InitializeValues();
    }

    // Update is called once per frame
    void InitializeValues()
    {
        health = maxHealth;
        UpdateHealth();
    }

    void UpdateHealth()
    {
        if (healthText != null)
            healthText.text = "HEALTH: " + health;
    }

    public void DamageHealth(int damage)
    {
        health -= damage;
        UpdateHealth();
    }

	void OnGUI()
	{
		switch(health)
		{
		case 0:
			break;
		case 1:
			GUI.Box(new Rect(0f,0f,Screen.width * 0.05f,Screen.height * 0.05f),icon);
			break;
		case 2:
			GUI.Box(new Rect(0f,0f,Screen.width * 0.05f,Screen.height * 0.05f),icon);
			GUI.Box(new Rect(Screen.width* 0.05f,0f,Screen.width * 0.05f,Screen.height * 0.05f),icon);
			break;
		case 3:
			GUI.Box(new Rect(0f,0f,Screen.width * 0.05f,Screen.height * 0.05f),icon);
			GUI.Box(new Rect(Screen.width* 0.05f,0f,Screen.width * 0.05f,Screen.height * 0.05f),icon);
			GUI.Box(new Rect(Screen.width* 0.1f,0f,Screen.width * 0.05f,Screen.height * 0.05f),icon);
			break;
		case 4:
			GUI.Box(new Rect(0f,0f,Screen.width * 0.05f,Screen.height * 0.05f),icon);
			GUI.Box(new Rect(Screen.width* 0.05f,0f,Screen.width * 0.05f,Screen.height * 0.05f),icon);
			GUI.Box(new Rect(Screen.width* 0.1f,0f,Screen.width * 0.05f,Screen.height * 0.05f),icon);
			GUI.Box(new Rect(Screen.width* 0.15f,0f,Screen.width * 0.05f,Screen.height * 0.05f),icon);
			break;
		case 5:
			GUI.Box(new Rect(0f,0f,Screen.width * 0.05f,Screen.height * 0.05f),icon);
			GUI.Box(new Rect(Screen.width* 0.05f,0f,Screen.width * 0.05f,Screen.height * 0.05f),icon);
			GUI.Box(new Rect(Screen.width* 0.1f,0f,Screen.width * 0.05f,Screen.height * 0.05f),icon);
			GUI.Box(new Rect(Screen.width* 0.15f,0f,Screen.width * 0.05f,Screen.height * 0.05f),icon);
			GUI.Box(new Rect(Screen.width* 0.2f,0f,Screen.width * 0.05f,Screen.height * 0.05f),icon);
			break;
		case 6:
			GUI.Box(new Rect(0f,0f,Screen.width * 0.05f,Screen.height * 0.05f),icon);
			GUI.Box(new Rect(Screen.width* 0.05f,0f,Screen.width * 0.05f,Screen.height * 0.05f),icon);
			GUI.Box(new Rect(Screen.width* 0.1f,0f,Screen.width * 0.05f,Screen.height * 0.05f),icon);
			GUI.Box(new Rect(Screen.width* 0.15f,0f,Screen.width * 0.05f,Screen.height * 0.05f),icon);
			GUI.Box(new Rect(Screen.width* 0.2f,0f,Screen.width * 0.05f,Screen.height * 0.05f),icon);
			GUI.Box(new Rect(Screen.width* 0.25f,0f,Screen.width * 0.05f,Screen.height * 0.05f),icon);

			break;
		case 7:
			GUI.Box(new Rect(0f,0f,Screen.width * 0.05f,Screen.height * 0.05f),icon);
			GUI.Box(new Rect(Screen.width* 0.05f,0f,Screen.width * 0.05f,Screen.height * 0.05f),icon);
			GUI.Box(new Rect(Screen.width* 0.1f,0f,Screen.width * 0.05f,Screen.height * 0.05f),icon);
			GUI.Box(new Rect(Screen.width* 0.15f,0f,Screen.width * 0.05f,Screen.height * 0.05f),icon);
			GUI.Box(new Rect(Screen.width* 0.2f,0f,Screen.width * 0.05f,Screen.height * 0.05f),icon);
			GUI.Box(new Rect(Screen.width* 0.25f,0f,Screen.width * 0.05f,Screen.height * 0.05f),icon);

			break;
		case 8:
			GUI.Box(new Rect(0f,0f,Screen.width * 0.05f,Screen.height * 0.05f),icon);
			GUI.Box(new Rect(Screen.width* 0.05f,0f,Screen.width * 0.05f,Screen.height * 0.05f),icon);
			GUI.Box(new Rect(Screen.width* 0.1f,0f,Screen.width * 0.05f,Screen.height * 0.05f),icon);
			GUI.Box(new Rect(Screen.width* 0.15f,0f,Screen.width * 0.05f,Screen.height * 0.05f),icon);
			GUI.Box(new Rect(Screen.width* 0.2f,0f,Screen.width * 0.05f,Screen.height * 0.05f),icon);
			GUI.Box(new Rect(Screen.width* 0.25f,0f,Screen.width * 0.05f,Screen.height * 0.05f),icon);
			GUI.Box(new Rect(Screen.width* 0.3f,0f,Screen.width * 0.05f,Screen.height * 0.05f),icon);
			GUI.Box(new Rect(Screen.width* 0.35f,0f,Screen.width * 0.05f,Screen.height * 0.05f),icon);
			break;
		case 9:
			GUI.Box(new Rect(0f,0f,Screen.width * 0.05f,Screen.height * 0.05f),icon);
			GUI.Box(new Rect(Screen.width* 0.05f,0f,Screen.width * 0.05f,Screen.height * 0.05f),icon);
			GUI.Box(new Rect(Screen.width* 0.1f,0f,Screen.width * 0.05f,Screen.height * 0.05f),icon);
			GUI.Box(new Rect(Screen.width* 0.15f,0f,Screen.width * 0.05f,Screen.height * 0.05f),icon);
			GUI.Box(new Rect(Screen.width* 0.2f,0f,Screen.width * 0.05f,Screen.height * 0.05f),icon);
			GUI.Box(new Rect(Screen.width* 0.25f,0f,Screen.width * 0.05f,Screen.height * 0.05f),icon);
			GUI.Box(new Rect(Screen.width* 0.3f,0f,Screen.width * 0.05f,Screen.height * 0.05f),icon);
			GUI.Box(new Rect(Screen.width* 0.35f,0f,Screen.width * 0.05f,Screen.height * 0.05f),icon);
			GUI.Box(new Rect(Screen.width* 0.4f,0f,Screen.width * 0.05f,Screen.height * 0.05f),icon);
			break;
		default:
			GUI.Box(new Rect(0f,0f,Screen.width * 0.05f,Screen.height * 0.05f),icon);
			GUI.Box(new Rect(Screen.width* 0.05f,0f,Screen.width * 0.05f,Screen.height * 0.05f),icon);
			GUI.Box(new Rect(Screen.width* 0.1f,0f,Screen.width * 0.05f,Screen.height * 0.05f),icon);
			GUI.Box(new Rect(Screen.width* 0.15f,0f,Screen.width * 0.05f,Screen.height * 0.05f),icon);
			GUI.Box(new Rect(Screen.width* 0.2f,0f,Screen.width * 0.05f,Screen.height * 0.05f),icon);
			GUI.Box(new Rect(Screen.width* 0.25f,0f,Screen.width * 0.05f,Screen.height * 0.05f),icon);
			GUI.Box(new Rect(Screen.width* 0.3f,0f,Screen.width * 0.05f,Screen.height * 0.05f),icon);
			GUI.Box(new Rect(Screen.width* 0.35f,0f,Screen.width * 0.05f,Screen.height * 0.05f),icon);
			GUI.Box(new Rect(Screen.width* 0.4f,0f,Screen.width * 0.05f,Screen.height * 0.05f),icon);
			GUI.Box(new Rect(Screen.width* 0.45f,0f,Screen.width * 0.05f,Screen.height * 0.05f),icon);

			break;

		}
	}
}
