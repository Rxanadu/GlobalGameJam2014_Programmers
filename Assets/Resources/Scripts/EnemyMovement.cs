using UnityEngine;
using System.Collections;

public class EnemyMovement : MonoBehaviour
{

    public enum EnemyType { 
        Straight,Fly
    }
    public EnemyType enemyType = EnemyType.Straight;

    public float detectionDistance;
    public float speed;
    public int healthDamage = 3;

    Transform target;
    bool playerDetected;
    PlayerHealth playerHealth;

    // Use this for initialization
    void Start()
    {
        playerHealth = GameObject.FindGameObjectWithTag(Tags.playerHealth).GetComponent<PlayerHealth>();

        playerDetected = false;
    }

    // Update is called once per frame
    void Update()
    {
        ChangeEnemyType();        
    }

    void OnCollisionEnter(Collision other) {
        if (other.gameObject.tag == Tags.player) {
            Destroy(gameObject);
            playerHealth.DamageHealth(healthDamage);
        }
    }

    void OnTriggerEnter(Collider other) {
        if (other.tag == Tags.player) {
            target = other.transform;
            playerDetected = true;
        }
    }

    void OnTriggerExit(Collider other) {
        if (other.tag == Tags.player)
        {
            target = null;
            playerDetected = false;
        }
    }

    void ChangeEnemyType() {
        switch (enemyType) { 
            case EnemyType.Straight:
                MoveStraightEnemy();
                break;
            case EnemyType.Fly:
                MoveFlyingEnemy();
                break;
        }
    }

    void MoveFlyingEnemy() {
        if (playerDetected) {
            float step = speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, target.position, step);
        }
    }

    void MoveStraightEnemy() {
        Ray ray = new Ray(transform.position, transform.right);

        RaycastHit hit; // declare the RaycastHit variable
        if (Physics.Raycast(ray, out hit))
        {
            Debug.DrawLine(ray.origin, hit.point);
            if (hit.transform.tag == Tags.player)
            {
                print("Distance: " + Vector3.Distance(transform.position, hit.transform.position));
                if (Vector3.Distance(transform.position, hit.transform.position) < detectionDistance)
                {
                    float step = speed * Time.deltaTime;
                    transform.position = Vector3.MoveTowards(transform.position, hit.transform.position, step);
                }
            }
        }
    }
}