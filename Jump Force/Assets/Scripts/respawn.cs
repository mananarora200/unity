using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class respawn : MonoBehaviour
{
    private BoxCollider bx;
    private float halfway;
    private Vector3 rePos;
    // Start is called before the first frame update
    void Start()
    {
        bx = GetComponent<BoxCollider>();
        halfway = bx.size.x / 2;
        rePos = transform.position;
        Debug.Log(halfway);
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x < rePos.x - halfway)
        {
            transform.position = rePos;
        }
    }
}
