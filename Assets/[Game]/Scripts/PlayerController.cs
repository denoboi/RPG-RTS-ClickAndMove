using System.Collections;
using UnityEngine;
using System.Collections.Generic;
using RPG.Movement;

namespace RPG.Control
{
    public class PlayerController : MonoBehaviour
    {
        void Update()
        {
            if (Input.GetMouseButton(1))
            {
                MoveToCursor();
            }
        }

        void MoveToCursor()
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            bool hasHit = Physics.Raycast(ray, out hit);
            Debug.DrawRay(ray.origin, ray.direction * 299);

            if (hasHit)
            {
               GetComponent<Mover>().MoveTo(hit.point);
            }
        }


    }
}