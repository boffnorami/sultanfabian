﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerX : MonoBehaviour
{ 

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    public GameObject plane;
    private Vector3 offset = new Vector3(28, 3, 4);
    void Update()
    {
        transform.position = plane.transform.position + offset;
    }
}
