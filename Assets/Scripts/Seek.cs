using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

public class Seek : SteeringBehaviour
{
    public GameObject targetGameObject;

    public Vector3 target;

    private void Start()
    {
        enabled = false;
    }

    public void OnDrawGizmos()
    {
        if (isActiveAndEnabled && Application.isPlaying)
        {
            Gizmos.color = Color.cyan;
            if (targetGameObject != null)
            {
                target = targetGameObject.transform.position;
            }
            Gizmos.DrawLine(transform.position, target);
        }
    }

    public override Vector3 Calculate()
    {
        return boid.SeekForce(target);
    }

    public void Update()
    {
        if (targetGameObject != null)
        {
            target = new Vector3(targetGameObject.transform.position.x, 0f, targetGameObject.transform.position.z);
        }
    }
}