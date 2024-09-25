using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject obstaclePrefab;
    public Vector3 spawmPosition = new Vector3(25, 0, 0);
    public float spawnDelay = 2.0f;
    public float spawnInterval = 2.0f;
    private PlayerController playerControllerScript;
    // Start is called before the first frame update
    void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
        InvokeRepeating("SpawnObstacle", spawnDelay, spawnInterval);
    }

    // Update is called once per frame
    void SpawnObstacle()
    {
        if (playerControllerScript.gameOver == false)
        {
            GameObject obstacle = Instantiate(obstaclePrefab, spawmPosition, obstaclePrefab.transform.rotation);
            obstacle.transform.parent = transform;
        }
    }
}
