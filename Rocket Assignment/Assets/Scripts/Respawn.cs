using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    public Transform spawnPoint;
    Rigidbody body;
    Respawn respawn;
    Score scorecounter;
    
    void Start()
    {
        body = GetComponent<Rigidbody>();
        respawn = GetComponent<Respawn>();
        scorecounter = GetComponent<Score>();
    }

    public void DieAndRespawn()
    {
        Debug.Log("Nooooooooo!");
        transform.position = spawnPoint.transform.position;
        body.velocity = Vector3.zero;
        body.angularVelocity = Vector3.zero;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Checkpoint")
        {
            Debug.Log("You reached a checkpoint!");
            scorecounter.GiveScore(200);
            respawn.spawnPoint = other.transform;
        }

          if (other.tag == "Death")
        {
            Debug.Log("Time to DIE!");
            scorecounter.GiveScore(-50);
            DieAndRespawn();
        }
    }
}
