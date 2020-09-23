using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateObstacle : MonoBehaviour
{
    public float respawnTime = 3f;
    float spawns = 0;
    public GameObject infiniteObject;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(infiniteObject, transform.position, transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        respawnTime -= Time.deltaTime;
        if(respawnTime < 0.0f)
        {
            Instantiate(infiniteObject, transform.position, transform.rotation);
            spawns += 0.10f;
            respawnTime = 3f - spawns;
        }
    }
}
