using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour
{

    public GameObject explosion, otherExplosion;
    public int enemyDamage;

    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == Tags.elevator)
        {
            return;
        }

        if (other.gameObject.tag == Tags.enemy)
        {
            other.gameObject.GetComponent<EnemyHealth>().DamageEnemy(enemyDamage);
        }

        Destroy(gameObject);
        if (explosion != null)
            Instantiate(explosion, transform.position, Quaternion.identity);
    }
}