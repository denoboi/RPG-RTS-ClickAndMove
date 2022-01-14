using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class Mover : MonoBehaviour
{
    [SerializeField] Transform target;

    NavMeshAgent navMeshAgent;

    Ray ray;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
        //navMeshAgent.destination = target.position;

        if (Input.GetMouseButton(1))
        {
            MoveToCursor();
        }

        UpdateAnimation();
            
    }

    void MoveToCursor()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        bool hasHit = Physics.Raycast(ray, out hit);
        Debug.DrawRay(ray.origin, ray.direction * 299);

        if (hasHit)
        {
            navMeshAgent.destination = hit.point;
        }
    }

    void UpdateAnimation()
    {
        
        Vector3 velocity = GetComponent<NavMeshAgent>().velocity;
        Vector3 localVelocity = transform.InverseTransformDirection(velocity);
        float speed = localVelocity.z;
        GetComponent<Animator>().SetFloat("ForwardSpeed", speed);
        
    }
}
