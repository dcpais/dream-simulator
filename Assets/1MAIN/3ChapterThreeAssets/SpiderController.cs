using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class SpiderController : MonoBehaviour
{
    public NavMeshAgent agent;
    public Transform target;
    public Animation animations;

    private void Start()
    {
        //this.target = GameObject.FindWithTag("Player").transform;
        Destroy(gameObject, 60);
    }

    private void Update()
    {
        animations.Play();
        Ray groundRay = new Ray(target.position, Vector3.down);
        RaycastHit hit;
        if (Physics.Raycast(groundRay, out hit))
        {
            agent.SetDestination(target.position);

        }

        //transform.LookAt(target);
    }
}

