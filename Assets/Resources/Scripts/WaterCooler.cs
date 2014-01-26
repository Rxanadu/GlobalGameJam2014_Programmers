using UnityEngine;
using System.Collections;

public class WaterCooler : MonoBehaviour
{
    public int health;
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

        activated = false;
        used = false;
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
            playerHealth.Health = playerHealth.maxHealth;
            Destroy(gameObject);
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
}