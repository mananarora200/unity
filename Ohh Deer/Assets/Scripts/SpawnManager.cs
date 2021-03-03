using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] prefab;
    private float leftBound = 20.0f;
    private float rightBound = -20.0f;
    private float spawnZ = 20.0f;
    private float initime = 2.0f;
    private float reptime = 1.5f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spawnAnimals", initime, reptime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void spawnAnimals()
    {
        int index = Random.Range(0, prefab.Length);
        Vector3 spawnloc = new Vector3(Random.Range(leftBound, rightBound), 0, spawnZ);
        Instantiate(prefab[index], spawnloc, prefab[index].transform.rotation);
    }
}
