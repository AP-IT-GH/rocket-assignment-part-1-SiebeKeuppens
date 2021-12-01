using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{
    Respawn respawn;
    public bool level1finished = false;
    void Start()
    {
            respawn = GetComponent<Respawn>();
    }

    public void nextLevel()
    {
        if (level1finished == true)
        {
            respawn.spawnPoint = transform;
        }
    }
    
}
