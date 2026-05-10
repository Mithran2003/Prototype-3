using System;
using System.Collections;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField]
    private GameObject[] ObstacleList;
    private Vector3 SpwanPoint;
    private short RandomObstacleIndex;
    [SerializeField]
    private float TimeToSpawn;
    [SerializeField]
    private float SpawnDelay;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SpwanPoint = new Vector3(20f,0,0);
        InvokeRepeating("SpwanObstacle",SpawnDelay,TimeToSpawn);
    }

    // Update is called once per frame
    void Update()
    {
        RandomObstacleIndex = Convert.ToInt16(UnityEngine.Random.Range(0,2));
    }

    void  SpwanObstacle()
    {
        Instantiate(ObstacleList[RandomObstacleIndex],SpwanPoint,ObstacleList[RandomObstacleIndex].transform.rotation);
    }
}
