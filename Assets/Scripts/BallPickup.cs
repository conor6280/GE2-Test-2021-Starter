using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallPickup : MonoBehaviour
{
    public GameObject Dog;
    public bool hasBall = false;
    public Collider collider;

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Ball" && hasBall == false)
        {
            collider.transform.parent = Dog.transform;
            hasBall = true;
            Dog.GetComponent<Arrive>().enabled = true;
            Dog.GetComponent<Seek>().enabled = false;

        }

        //gameObject.transform.parent = null;
    }
}
