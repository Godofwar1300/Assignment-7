using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * (Christopher Green)
 * (DestroyOnjectX.cs)
 * (Assignment 7 - Challenge 5)
 * (The script handles destroying the particle effects.)
 */

public class DestroyObjectX : MonoBehaviour
{
    void Start()
    {
        Destroy(gameObject, 2); // destroy particle after 2 seconds
    }


}
