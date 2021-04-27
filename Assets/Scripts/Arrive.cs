﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

public class Arrive : SteeringBehaviour
{
    public GameObject dog;
    public GameObject player;

    public Vector3 targetPosition = Vector3.zero;
    public float slowingDistance = 15.0f;

    public GameObject targetGameObject = null;

    private void Start()
    {
        enabled = false;
    }

    public override Vector3 Calculate()
    {
        return boid.ArriveForce(targetPosition, slowingDistance);
    }

    public void Update()
    {
        if (targetGameObject != null)
        {
            targetPosition = new Vector3(targetGameObject.transform.position.x, 0f, targetGameObject.transform.position.z);
        }
    }
}