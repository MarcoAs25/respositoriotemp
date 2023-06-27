using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField]
    private float timeToSpawn;
    [SerializeField]
    private GameObject goPipe;
    [SerializeField]
    private float maxDistance;
    [SerializeField]
    private float minDistance;
    void Start()
    {
        Invoke("SpawnPipes", timeToSpawn);
    }
    public void SpawnPipes()
    {
        Instantiate(goPipe, transform.position + Vector3.up * Random.Range(maxDistance,
       minDistance), Quaternion.identity);
        Invoke("SpawnPipes", timeToSpawn);
    }
}