/*
 * Created by: Ruel Coy
 *
 * Purpose: Handles the spawning of the obstacle 
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateObstacle : MonoBehaviour
{
    public float respawnTime = 3f;
    float _spawns = 0;
    public GameObject infiniteObject;
    
    void Start()
    {
        Instantiate(infiniteObject, transform.position, transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        respawnTime -= Time.deltaTime; // Decreases respawn time by 1f a second.
        if(respawnTime < 0.0f)
        {
            Instantiate(infiniteObject, transform.position, transform.rotation);
            _spawns += 0.10f; // Decreases the time for next obstacle spawn by .10 seconds.
            respawnTime = 3f - _spawns;
        }
    }
}
