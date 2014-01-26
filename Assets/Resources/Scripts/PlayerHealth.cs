using UnityEngine;
using System.Collections;

public class PlayerHealth : MonoBehaviour {

    public GUIText healthText;
    public int maxHealth = 10;

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
}
