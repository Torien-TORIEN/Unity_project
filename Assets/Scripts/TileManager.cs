using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileManager : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject[] tilePrefabs;

    public float zSpawn = 0;  //z position of spawn

    public float tilelength = 30;

    void Start()
    {
        SpawnTile(0);
        SpawnTile(1);
        SpawnTile(4);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnTile(int tileIndex)
    {
        Instantiate(tilePrefabs[tileIndex], transform.forward * zSpawn, transform.rotation);
        zSpawn += tilelength;
    }
}
