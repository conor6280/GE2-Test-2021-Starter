using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoggoStates : MonoBehaviour
{
    public enum States {Arrive, Wait, Drop, Seek}

    public GameObject Player;
    public GameObject Dog;
    public BallPickup pickup;

    public static States state;

    void Update()
    {
        
        switch(state)
        {
            case States.Wait:
                Dog.GetComponent<Seek>().enabled = false;
                Dog.GetComponent<Arrive>().enabled = false;
                break;

            case States.Seek:
                Dog.GetComponent<Seek>().enabled = true;
                Dog.GetComponent<Arrive>().enabled = false;
                break;

            case States.Arrive:
                Dog.GetComponent<Seek>().enabled = false;
                Dog.GetComponent<Arrive>().enabled = true;
                break;

            case States.Drop:
                Destroy(GameObject.FindGameObjectWithTag("Ball"));
                Player.GetComponent<BallThrow>().haveBall = true;
                pickup.hasBall = false;
                state = States.Wait;
                break;
        }

    }
}
