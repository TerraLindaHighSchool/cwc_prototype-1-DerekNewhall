﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset = new Vector3(0, 7, -9);
    // Start is called before the first frame update
    void Start()
    {

    }
   
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
}
