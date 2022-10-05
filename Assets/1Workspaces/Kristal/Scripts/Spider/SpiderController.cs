using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine AI;

public class SpiderController : MonoBehaviour
{
   private UnityEngine.AI.NavMeshAgent agent = null;
   [SerializeField] private Transform target;

   private void Start() 
   {
        GetRefernces();
   }

   private void Update() 
   {
        MoveToTarget();
   }

   private void MoveToTarget() 
   {
        agent.SetDestination(target.position);
   }
   
   private void GetRefernces() 
   {
        agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
   }
 
}
