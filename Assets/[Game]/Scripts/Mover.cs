using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class Mover : MonoBehaviour
{
    [SerializeField] Transform target;

    NavMeshAgent navMeshAgent;

    [SerializeField] private float speed = 10f;

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

        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * Time.deltaTime * speed);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * Time.deltaTime * speed);
        }
    }

//    void MoveToCursor()
//    {
//        //Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
//       //RaycastHit hit;
//        //bool hasHit = Physics.Raycast(ray, out hit);
//        //Debug.DrawRay(ray.origin, ray.direction * 299);

//        //if (hasHit)
//        {
//            navMeshAgent.destination = hit.point;
//        }
//    }
}
