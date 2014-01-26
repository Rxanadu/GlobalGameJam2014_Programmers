using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {

    public GameObject explosion, otherExplosion;

    void OnTriggerEnter(Collider other) {

        if (other.gameObject.tag == Tags.elevator) {
            return;
        }

        if (other.gameObject.tag == Tags.enemy) {
            Destroy(other.gameObject);
            if(otherExplosion!=null)
                Instantiate(otherExplosion, transform.position, Quaternion.identity);
        }
        Destroy(gameObject);
        if (explosion != null)
            Instantiate(explosion, transform.position, Quaternion.identity);
    }
}
