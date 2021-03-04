using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnManager : MonoBehaviour
{
    public GameObject prefab;
    private Vector3 obstacleRotation = new Vector3(20, 0, 0);
    private float startTime = 2.0f;
    private float repeatTime = 2.0f;
    private PlayerController obj;
    // Start is called before the first frame update
    void Start()
    {
        obj = GameObject.Find("player").GetComponent<PlayerController>();
        InvokeRepeating("getObstacle", startTime, repeatTime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void getObstacle()
    {
        if (obj.isGameOver == false)
        {
            Instantiate(prefab, obstacleRotation, prefab.transform.rotation);
        }
    }
}
