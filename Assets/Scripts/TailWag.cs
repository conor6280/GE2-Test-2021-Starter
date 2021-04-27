using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TailWag : MonoBehaviour
{
    public float tailWagRate;
    public Transform tail;
    public float tailRadius;

    void Start()
    {


    }

    void Update()
    {
        tail.localRotation = Quaternion.RotateTowards(tail.localRotation, Quaternion.Euler(0, tailRadius, 0), tailWagRate);
        if (tail.localRotation == Quaternion.Euler(0, tailRadius, 0)) tailRadius = -tailRadius;
    }
}