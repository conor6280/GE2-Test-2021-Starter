using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallThrow : MonoBehaviour
{
    public GameObject Dog;
    public float fireRate = 1f;
    private float nextTimeToFire = 0f;
    public GameObject grenade;
    public float speed = 20;
    public Transform Hand;
    public GameObject Ball;

    void Update()
    {
        if (Input.GetButton("Fire1") && Time.time >= nextTimeToFire)
        {
            nextTimeToFire = Time.time + 1 / fireRate;
            Shoot();
        }
    }
    public void Shoot()
    {
        GameObject gren = Instantiate(grenade, Hand.position, Hand.rotation) as GameObject;
        gren.GetComponent<Rigidbody>().AddForce(Hand.forward * speed, ForceMode.Impulse);
        Dog.GetComponentInChildren<Seek>().targetGameObject = Ball;
        Dog.GetComponent<Seek>().enabled = true;
    }
}
