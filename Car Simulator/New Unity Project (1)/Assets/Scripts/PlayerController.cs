﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    private float horizontalInput;
    private float verticalInput;
    public float verticalSpeed = 10f;
    public float horizontalSpeed = 25f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * Time.deltaTime * verticalSpeed * verticalInput);
        transform.Rotate(Vector3.up, horizontalSpeed * horizontalInput * Time.deltaTime);
    }
}
