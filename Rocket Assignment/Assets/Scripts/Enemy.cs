using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    int r = 0;
    void Update()
    {
        transform.localRotation = Quaternion.Euler(0,0,r);
        r++;
    }
}
