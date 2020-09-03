using Microsoft.Win32;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndlessMap : MonoBehaviour
{
    public GameObject[] tilePrefabs;
    public GameObject cloud;

    public float zSpawn = 0;
    public float tileLength = -12.02415f;

    public int numberOfTiles = 3;

    private List<GameObject> activeTiles = new List<GameObject>();

    public Transform playerTransform;
    void Start()
    {
        for (int i = 0; i < numberOfTiles; i++)
        {
            if (i == 0)
                SpawnTile(0);
            else
                SpawnTile(Random.Range(0, tilePrefabs.Length));
        }

    }
    void Update()
    {
        if (playerTransform.position.z + 12.02415f < zSpawn - (numberOfTiles * tileLength))
        {
            SpawnTile(Random.Range(0, tilePrefabs.Length));
            DeleteTile();
        }
    }
    public void SpawnTile(int tileIndex)
    {

        GameObject go = Instantiate(tilePrefabs[tileIndex], transform.forward * zSpawn, transform.rotation);
        activeTiles.Add(go);
        zSpawn += tileLength;

        int random1 = Random.Range(-10, 10);
        int random2 = Random.Range(-10, 10);
        var random3 = transform.rotation;
        if(-3 < random1 & random1 < 3 & -3 < random2 & random2 < 3)
        {           
            Debug.Log(random1);
            Debug.Log(random2);
                random1 = Random.Range(-10, 10); 
                random2 = Random.Range(-10, 10);

        }
        else
        {
            random3.y = Random.Range(-100, 100);
            Instantiate(cloud, new Vector3(random1, random2, playerTransform.position.z - 50), random3);
        }
    }

    private void DeleteTile()
    {
        Destroy(activeTiles[0]);
        activeTiles.RemoveAt(0);

    }
}
