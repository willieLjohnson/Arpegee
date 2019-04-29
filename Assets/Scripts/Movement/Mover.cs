﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Mover : MonoBehaviour
{
  [SerializeField] Transform target;

  Ray lastRay;

  // Update is called once per frame
  void Update()
  {
    //if (Input.GetMouseButton(0))
    //{
    //  MoveToCursor();
    //}
    UpdateAnimator();
  }


  private void MoveToCursor()
  {
    Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
    RaycastHit hit;
    bool hasHit = Physics.Raycast(ray, out hit);
    if (hasHit)
    {
      MoveTo(hit.point);
    }
  }

  public void MoveTo(Vector3 destination)
  {
    NavMeshAgent agent = GetComponent<NavMeshAgent>();
    agent.destination = destination;
  }

  private void UpdateAnimator()
  {
    Vector3 velocity = GetComponent<NavMeshAgent>().velocity;
    Vector3 localVelocity = transform.InverseTransformDirection(velocity);
    float speed = localVelocity.z;
    GetComponent<Animator>().SetFloat("forwardSpeed", speed);

  }
}
