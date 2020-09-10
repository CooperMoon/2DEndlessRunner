using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Code reference link: https://www.youtube.com/watch?v=NtY_R0g8L8E
public class Spawner : MonoBehaviour
    {
    private const float PLAYER_DISTANCE = 100f;

    #region Level Transform Variables 
    //Transform variables for the level, start and player            
    [SerializeField] private List<Transform> levelList;     // Variable array used to store the level prefabs for spawning
    [SerializeField] private Transform StartPos;            // Variable for finding the platforms starting position
    [SerializeField] private Transform player;              // Variable for finding the player
    #endregion

    private int n = 5;          // interger for how many platforms we want to spawn on awake

    private Vector3 lastEnd;    // A variable to find the Last levels end position

    private void Awake()
    {
        // this is used to find the end position
        lastEnd = StartPos.Find("EndPos").position;

        int spawningLevelPrefabs = n; //spawns 5 level prefabs
        
        // i is less than 5 spawn prefab 5 times then break
        for (int i = 0; i < spawningLevelPrefabs; i++)
        {
            SpawnPrefab();
        }
    }

    #region Spawning
    private void Update()
    {
        //when player is x distance from end spawn more prefabs

        if (Vector3.Distance(player.position, lastEnd) < PLAYER_DISTANCE) // if player is x amount from the end position of the last prefab
        {
            //spawn another level prefab
            SpawnPrefab();
        }
    }

   
    private void SpawnPrefab()
    {
        //chooses a random level prefab to spawn at next end position
        Transform chosenLevelPart = levelList[Random.Range(0, levelList.Count)];

        //automatically spawns a level prefab and locates the end position to spawn the next one
        Transform lastLevelTransform = SpawnPrefab(chosenLevelPart, lastEnd);
        lastEnd = lastLevelTransform.Find("EndPos").position;

    }
    private Transform SpawnPrefab(Transform level, Vector3 spawnPos)
    {
        //This transform method spawns the level prefabs when called
        Transform levelTransform = Instantiate(level, spawnPos, Quaternion.identity);
        return levelTransform;

    }
    #endregion
}

