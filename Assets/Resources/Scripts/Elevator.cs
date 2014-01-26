using UnityEngine;
using System.Collections;
using System;

/// <summary>
/// @Usage: place on elevator's trigger (should be parent of elevator object)
/// </summary>
public class Elevator : MonoBehaviour
{
    //place floors in ascending order 
    //	(e.g. index 0 is floor 1, index 1 is floor 2, etc.)
    public Transform[] floors;
    public float speed;

    Vector3 nextFloor;
    bool onElevator;
    bool movingUp, movingDown;
    public int clearance;

    void Start()
    {
        onElevator = false;
        movingUp = false;
        movingDown = false;
        nextFloor = Vector3.zero;
        KeyCard.clearanceUp += UnlockFloorAccess;
    }

    void Update()
    {
        if (onElevator)
        {
            if (Input.GetKeyDown(KeyCode.W) && !movingDown)
            {
                //if floor above is active
                movingUp = true;
            }

            if (Input.GetKeyDown(KeyCode.S) && !movingUp)
            {
                //if floor above is active
                movingDown = true;
            }
        }

        //move player up a level
        if (movingUp && !movingDown)
        {
            //if (clearance >= (int)nextFloor.y)//clearance added
           // {
                for (int i = 0; i < floors.Length; i++)
                {
                    if (floors[i].position.y == transform.parent.position.y)
                    {
                        nextFloor = floors[i + 1].position;

                    }
                    float step = speed * Time.deltaTime;
                    transform.parent.position = Vector3.MoveTowards(transform.parent.position, nextFloor, step);
                    if (transform.parent.position.y == nextFloor.y)
                    {
                        movingUp = false;
                    }
                }
           // }
           // else
           // {
           //     movingUp = false;
           // }

        }

        //move player down a level
        if (movingDown && !movingUp)
        {

            for (int i = 0; i < floors.Length; i++)
            {
                if (floors[i].position.y == transform.parent.position.y)
                {
                    nextFloor = floors[i - 1].position;

                }
            }
            float step = speed * Time.deltaTime;
            transform.parent.position = Vector3.MoveTowards(transform.parent.position, nextFloor, step);
            if (transform.parent.position.y == nextFloor.y)
            {
                movingDown = false;
            }
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            onElevator = true;
            other.transform.parent = this.gameObject.transform;
        }
    }
    void UnlockFloorAccess(bool isGood)
    {
        if (isGood)
        {
            clearance++;
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            onElevator = false;
            other.transform.parent = null;
        }
    }

}