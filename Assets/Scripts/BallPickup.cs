using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallPickup : MonoBehaviour
{
    public GameObject Player;
    public GameObject Dog;
    public Transform DogMouth;
    public GameObject Ball;

    public bool hasBall = false;
    public Collider Mycollider;

    private void Start()
    {
        hasBall = false;
    }

    private void OnTriggerEnter(Collider Mycollider)
    {
        if (Mycollider.gameObject.tag == "Ball" && hasBall == false)
        {
            Mycollider.transform.parent = DogMouth.transform;
            hasBall = true;
            DoggoStates.state = DoggoStates.States.Arrive;

        }
    }
}
