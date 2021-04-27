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
    public AudioSource Bork;
    public bool haveBall = true;


    public void Shoot()
    {
        GameObject gren = Instantiate(grenade, Hand.position, Hand.rotation) as GameObject;
        gren.GetComponent<Rigidbody>().AddForce(Hand.forward * speed, ForceMode.Impulse);
        Dog.GetComponent<Seek>().enabled = true;
        Dog.GetComponentInChildren<Seek>().ball = gren;
        Bork.Play();
    }
    void Update()
    {
        if (Input.GetButton("Fire1") && Time.time >= nextTimeToFire && haveBall == true)
        {
            nextTimeToFire = Time.time + 1 / fireRate;
            Shoot();
            haveBall = false;
            DoggoStates.state = DoggoStates.States.Seek;
        }
    }

}
