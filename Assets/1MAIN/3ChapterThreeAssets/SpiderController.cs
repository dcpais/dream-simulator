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
        agent = GetComponent<NavMeshAgent>();
        this.target = GameObject.FindWithTag("Player").transform;
        animations.PlayQueued("Attack");
        animations.PlayQueued("Attack");
        animations.PlayQueued("Walk");
        animations.PlayQueued("Walk");
        animations.PlayQueued("Walk");
        animations.PlayQueued("Walk");
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
        if (!animations.isPlaying) 
        {
            animations.Play("Walk");
        }
        //transform.LookAt(target);
    }
}

