using UnityEngine;
using System.Collections;

public class WaterCooler : MonoBehaviour
{
    public int health;
    public AudioClip waterDrinkClip;

    bool activated, used;
    PlayerHealth playerHealth;

    public bool Activated
    {
        get { return activated; }
    }

    public bool Used { get { return used; } }

    void Start()
    {
        playerHealth = GameObject.FindGameObjectWithTag(Tags.playerHealth).GetComponent<PlayerHealth>();

        if (waterDrinkClip != null)
            audio.clip = waterDrinkClip;

        activated = false;
        used = false;
        audio.playOnAwake = false;
        audio.loop = false;
    }

    void Update()
    {
        if (health <= 0 || used)
        {
            Destroy(this.gameObject);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == Tags.player)
        {

            DrinkWater();
            //if (activated && !used && playerHealth.Health <= 0)
            //{
            //    activated = false;
            //    used = true;
            //}
            //else { activated = true; }

        }
        //if (other.gameObject.tag == Tags.enemy)
        //{
        //    health--;
        //}
    }

    void DrinkWater() {
        collider.enabled = false;
        renderer.enabled = false;
        playerHealth.Health = playerHealth.maxHealth;

        audio.Play();
    }
}