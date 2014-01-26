using UnityEngine;
using System.Collections;

/// <summary>
/// @Usage: place on enemy object
/// </summary>
public class EnemyHealth : MonoBehaviour
{
    public int health;
    GameObject explosion;

    // Update is called once per frame
    void Update()
    {
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }

    public void DamageEnemy(int healthDamage)
    {
        health -= healthDamage;
    }

    void OnDestroy()
    {
        if (explosion != null)
            Instantiate(explosion, transform.position, Quaternion.identity);
    }
}
