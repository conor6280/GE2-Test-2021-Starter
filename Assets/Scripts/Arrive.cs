using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

public class Arrive : SteeringBehaviour
{
    public GameObject dog;
    public GameObject player;

    public AudioSource Bork;

    public Vector3 targetPosition = Vector3.zero;
    public float slowingDistance = 15.0f;

    public GameObject targetGameObject = null;

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

        if (Vector3.Distance (dog.transform.position, player.transform.position) < 10)
        {
            DoggoStates.state = DoggoStates.States.Wait;
            DoggoStates.state = DoggoStates.States.Drop;

        }
    }
}