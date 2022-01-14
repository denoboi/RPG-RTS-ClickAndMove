using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace RPG.Movement
{
    public class Mover : MonoBehaviour
    {
        [SerializeField] Transform target;
        NavMeshAgent navMeshAgent;
        Ray ray;

        void Update()
        {
            navMeshAgent = GetComponent<NavMeshAgent>();
            //navMeshAgent.destination = target.position;
            UpdateAnimation();
        }
        public void MoveTo(Vector3 destination)
        {
            navMeshAgent.destination = destination;
        }
        void UpdateAnimation()
        {
            Vector3 velocity = GetComponent<NavMeshAgent>().velocity;
            Vector3 localVelocity = transform.InverseTransformDirection(velocity);
            float speed = localVelocity.z;
            GetComponent<Animator>().SetFloat("ForwardSpeed", speed);
        }
    }
}

