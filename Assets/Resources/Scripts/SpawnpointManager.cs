using UnityEngine;
using System.Collections;

public class SpawnpointManager : MonoBehaviour
{

    //GameObject[] waterCoolers;
    GameObject player;

    public Transform respawn;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag(Tags.player);

        if (respawn != null)
            player.transform.position = respawn.position;

        //if (GameObject.FindGameObjectsWithTag(Tags.respawn) != null)
        //    waterCoolers = GameObject.FindGameObjectsWithTag(Tags.respawn);
    }

    //void Update()
    //{
    //    foreach (GameObject cooler in waterCoolers)
    //    {
    //        WaterCooler spawn = cooler.GetComponent<WaterCooler>();
    //        if (spawn.Activated && !spawn.Used)
    //        {
    //            respawn = cooler.transform;
    //            break;
    //        }
    //        else if (spawn.Activated && spawn.Used)
    //        {
    //            respawn = null;
    //        }
    //    }
    //}
}