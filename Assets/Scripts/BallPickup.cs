using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallPickup : MonoBehaviour
{
    public GameObject Dog;
    public bool hasBall = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Ball" && hasBall == false)
        {
            other.transform.parent = Dog.transform;
            hasBall = true;
        }

        //gameObject.transform.parent = null;
    }
}
