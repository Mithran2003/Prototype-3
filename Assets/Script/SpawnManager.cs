using System;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField]
    private GameObject[] ObstacleList;
    private Vector3 SpwanPoint;
    private short RandomObstacleIndex;
    private float TimeToSpawn;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        SpwanPoint = new Vector3(20f,0,0); 
    }

    // Update is called once per frame
    void Update()
    {
        RandomObstacleIndex = Convert.ToInt16(UnityEngine.Random.Range(0,2));
    }
}
