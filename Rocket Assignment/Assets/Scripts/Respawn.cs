using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    public Transform spawnPoint;
    public Transform Level2;
    Rigidbody body;
    Respawn respawn;
    Score scorecounter;
    Level level;
    
    void Start()
    {
        body = GetComponent<Rigidbody>();
        respawn = GetComponent<Respawn>();
        scorecounter = GetComponent<Score>();
        level = GetComponent<Level>();
    }

    public void DieAndRespawn()
    {
        transform.position = spawnPoint.transform.position;
        body.velocity = Vector3.zero;
        body.angularVelocity = Vector3.zero;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "End1")
        {
            Debug.Log("You finished level 1!");
            scorecounter.GiveScore(100);
            respawn.spawnPoint = Level2;
            DieAndRespawn();
        }

        if (other.tag == "End2")
        {
            Debug.Log("You finished level 2!");
            scorecounter.GiveScore(200);
            respawn.spawnPoint = other.transform;
        }

        if (other.tag == "Points")
        {
            Debug.Log("You got some points!");
            scorecounter.GiveScore(10);
            Destroy(other.gameObject);
        }

          if (other.tag == "Death")
        {
            Debug.Log("You died!");
            scorecounter.GiveScore(-50);
            DieAndRespawn();
        }
    }
}
