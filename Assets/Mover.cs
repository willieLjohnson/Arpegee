﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Mover : MonoBehaviour
{
  [SerializeField] Transform target;

  // Update is called once per frame
  void Update()
  {
    NavMeshAgent agent = GetComponent<NavMeshAgent>();
    agent.destination = target.position;
  }
}
