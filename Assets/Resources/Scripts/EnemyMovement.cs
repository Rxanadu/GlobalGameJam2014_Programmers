using UnityEngine;
using System.Collections;

public class EnemyMovement : MonoBehaviour
{

    public enum EnemyType { 
        Ground,Air
    }
    public EnemyType enemyType = EnemyType.Ground;

    public float detectionDistance;
    public float speed;
    public int healthDamage = 3;
    public Transform firstNode, secondNode;
    public float waitTime = 2f;

    Transform target;
    bool playerDetected;
    bool movingToNode;
    PlayerHealth playerHealth;
    Vector3 nextNode;

    // Use this for initialization
    void Start()
    {
        playerHealth = GameObject.FindGameObjectWithTag(Tags.playerHealth).GetComponent<PlayerHealth>();
        transform.position = firstNode.position;
        playerDetected = false;
        movingToNode = true;
        nextNode = firstNode.position;
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
            case EnemyType.Ground:
                if (movingToNode && !playerDetected)
                {                    
                    TravelToNode();
                }
                else
                    MoveGroundEnemy();
                break;
            case EnemyType.Air:
                MoveAirEnemy();
                break;
        }
    }

    void MoveAirEnemy() {
        if (playerDetected) {
            float step = speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, target.position, step);
        }
    }

    void TravelToNode()
    {
        float step = speed * Time.deltaTime;

        if (transform.position.x == firstNode.position.x)
        {
            nextNode = secondNode.position;
        }
        if (transform.position.x == secondNode.position.x)
        {
            nextNode = firstNode.position;
        }

        transform.position = Vector3.MoveTowards(transform.position, nextNode, step);
    }

    void MoveGroundEnemy() {
        Ray ray = new Ray(transform.position, transform.right);

        RaycastHit hit; // declare the RaycastHit variable
        if (Physics.Raycast(ray, out hit))
        {            
            Debug.DrawLine(ray.origin, hit.point);
            if (hit.transform.tag == Tags.player)
            {
                movingToNode = false;
                playerDetected = true;
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