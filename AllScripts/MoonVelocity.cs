﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MoonVelocity : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        GetComponent<Rigidbody>().velocity = new Vector3(4.5f, 0, 0);





    }
}
