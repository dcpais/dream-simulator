using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI; 

public class SpiderController : MonoBehaviour
{
    private NavMeshAgent agent;
    public Transform target;
    public LayerMask whatIsGround, whatIsPlayer;

    //Patrolling
    public Vector3 walkPoint;
    bool walkPointSet;
    public float walkPointRange;

    //Attacking
    public float timeBetweenAttacks;
    private bool alreadyAttacked;

    public float jumpRange;
    public float chaseRange;
    private bool playerInSightRange, playerInJumpRange;

    private void Awake()
        {
            GetReferences();
            this.target = GameObject.FindWithTag("Player").transform;
        }

        private void Update()
        {
            playerInSightRange = Physics.CheckSphere(transform.position, chaseRange, whatIsPlayer);
            if (playerInSightRange) 
            {
                MoveToTarget();
            }
        }

        private void MoveToTarget()
        {
            agent.SetDestination(target.position);
            transform.LookAt(target);   
        }

        private void GetReferences()
        {
            agent = GetComponent<NavMeshAgent>(); 
        }

    }

