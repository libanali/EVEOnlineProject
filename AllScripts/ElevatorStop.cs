﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevatorStop : MonoBehaviour
{
    public GameObject Elevator;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        Elevator.GetComponent<Patrol>().enabled = false;
    }
}
